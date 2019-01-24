using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeSheet.Authorization;
using TimeSheet.Domain.Enty.Interface;
using TimeSheet.Domain.Interface;
using TimeSheet.Infrastructure.ServiceRepository;

namespace TimeSheet
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Login";
                    options.Cookie.Name = "RDO";
                });

            services.AddAuthorization();
            services.AddMvc().AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddAutoMapper();
            services.AddSingleton<IAuthorizationHandler, OperationAuthorizationHandler>();
            services.AddSingleton<IConfiguracao, ConfiguracaoServiceRepository>();
            services.AddSingleton<IProtheus, ProtheusServiceRepository>();
            services.AddSingleton<IJornadaTrabalho, JornadaTrbServiceRepository>();
            services.AddSingleton<IMarcacao, MarcacaoServiceRepository>();
            services.AddSingleton<ILancamento, LancamentoServiceRepository>();
            services.AddSingleton<IFechamento, FechamentoServiceRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
