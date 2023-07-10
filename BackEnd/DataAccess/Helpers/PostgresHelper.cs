using Core.DB.Helper;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Helpers
{
    public class PostgresHelper : NhibernateHelper
    {
        private IConfiguration _configuration;

        public PostgresHelper(IConfiguration configuration)
        {
            _configuration=configuration;
        }

        protected override ISessionFactory InitializeFactory()
        {
            var build = Fluently.Configure().Database(PostgreSQLConfiguration.PostgreSQL82
                .ConnectionString(_configuration.GetConnectionString("PostreSQLConnection")))
                 .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                 .ExposeConfiguration(TreatConfiguration).BuildSessionFactory();
            return build;
        }
        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }

    }
}
