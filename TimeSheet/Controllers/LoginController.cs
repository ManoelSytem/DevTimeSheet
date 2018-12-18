using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using TimeSheet.ViewModel;

namespace TimeSheet.Controllers
{
   
    public class LoginController : Controller
    {
        public IActionResult Index(string ReturnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(new LoginViewModel() { ManterConectado = true, ReturnUrl = ReturnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var disco = await DiscoveryClient.GetAsync("http://localhost:8080");
                var tokenClient = new TokenClient(disco.TokenEndpoint, "Timesheet.Client", "timesheetSecret");
                var tokenResponse = await tokenClient.RequestResourceOwnerPasswordAsync(login.Username, login.Password, string.Join(" ", Scopes));

                if (!tokenResponse.IsError)
                {
                    var userInfo = new UserInfoClient(disco.UserInfoEndpoint);
                    var identityClaims = await userInfo.GetAsync(tokenResponse.AccessToken);
                    var claimsIdentity = new ClaimsIdentity(identityClaims.Claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var prop = new AuthenticationProperties() { IsPersistent = login.ManterConectado };
                    var tokens = new List<AuthenticationToken>
                    {
                        new AuthenticationToken {Name = OpenIdConnectParameterNames.AccessToken, Value = tokenResponse.AccessToken},
                        new AuthenticationToken {Name = OpenIdConnectParameterNames.RefreshToken, Value = tokenResponse.RefreshToken},
                        new AuthenticationToken {Name = OpenIdConnectParameterNames.ExpiresIn, Value = (DateTime.UtcNow + TimeSpan.FromSeconds(tokenResponse.ExpiresIn)).ToString("o", CultureInfo.InvariantCulture) }
                    };
                    prop.StoreTokens(tokens);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), prop);
                    if (!string.IsNullOrWhiteSpace(login.ReturnUrl))
                        return Redirect(login.ReturnUrl);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Não foi possível entrar. Verifique seu login e senha.");
                }
            }
            return View("Index", login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Loginteste(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", login);
            }

            if (login.Username == "Administrador" && login.Password == "123456")
            {
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,"Manoel"),
                    new Claim(ClaimTypes.Email,"manoelcontatosi@gmail.com"),
                    new Claim(ClaimTypes.Email,"Brasil"),
                    new Claim(ClaimTypes.NameIdentifier, "userId")
                }, "ApplicationCookie");

                if (!string.IsNullOrWhiteSpace(login.ReturnUrl))
                    return Redirect(login.ReturnUrl);
                return RedirectToAction("Index", "Home");
            }
            return View("Index", login);
        }

        [Authorize]
        public async Task<ActionResult> Logoff()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

        private static readonly string[] Scopes = {
            "Timesheet",
            "permissions",
            "dados",
            "openid",
            ClaimTypes.Role,
            ClaimTypes.Name,
            ClaimTypes.Email,
        };
    }
}
