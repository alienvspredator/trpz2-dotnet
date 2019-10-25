using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;
using WpfApp4.Models;

namespace WpfApp4.Core.Service
{
    class DbConnectionService
    {
        private static string connectionString;

        public static void SetCredentials(string username, string password)
        {
            string dataSource = ConfigurationManager.AppSettings["data-source"];
            string initialCatalog = ConfigurationManager.AppSettings["initial-catalog"];

            var builder = new SqlConnectionStringBuilder
            {
                DataSource = dataSource,
                ConnectTimeout = 1000,
                UserID = username,
                Password = password,
                InitialCatalog = initialCatalog,
                PersistSecurityInfo = true,
                MultipleActiveResultSets = true,
                ["App"] = "EntityFramework",
                TrustServerCertificate = true,
            };

            connectionString = builder.ConnectionString;
        }

        public static bool TestConnection(DbContext context)
        {
            return context.Database.Exists();
        }

        public static Library GetConnection()
        {
            if (connectionString == null)
            {
                throw new Exception("Credentials is empty");
            }

            return new Library(connectionString);
        }
    }
}
