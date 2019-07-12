using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Infrastructure.Interface
{
        public abstract class AbstractRepository<T>
        {
            private string _connectionString;
            private readonly IConfiguration Configuration;
            protected string ConnectionString => _connectionString;
            public AbstractRepository(IConfiguration configuration)
            {
                _connectionString = Configuration.GetSection("ProducaoConection")["Conection"];
               
            }

            public abstract void Add(T item, string filial, string matricula);
            public abstract void Remove(string id);
            public abstract void Update(T item);
            public abstract T FindByID(int id);
            public abstract T Find();
        }
 }

