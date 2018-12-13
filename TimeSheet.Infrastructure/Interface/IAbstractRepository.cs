using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheet.Infrastructure.Interface
{
        public abstract class AbstractRepository<T>
        {
            private string _connectionString;
            protected string ConnectionString => _connectionString;
            public AbstractRepository(IConfiguration configuration)
            {
                _connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=stark.intranet.bahiagas.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ap12hml)));User Id=ap6;Password=ap6;";

            }

            public abstract void Add(T item, string filial, string matricula);
            public abstract void Remove(string id);
            public abstract void Update(T item);
            public abstract T FindByID(int id);
            public abstract T Find();
        }
 }

