using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using WpfApp4.Models;

namespace WpfApp4.Core.Service
{
    internal class DbConnectionService
    {
        private static string connectionString;

        private static string GetSetting(string settingKey)
        {
            return ConfigurationManager.AppSettings[settingKey];
        }

        private static string BuildCredentials(string username, string password)
        {
            string dataSource = GetSetting("data-source");
            string initialCatalog = GetSetting("initial-catalog");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
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

            return builder.ConnectionString;
        }

        public static void SetCredentials(string username, string password)
        {
            connectionString = BuildCredentials(username, password);
        }

        public static bool TestConnection(DbContext context)
        {
            return context.Database.Exists();
        }

        public static LibraryContext GetConnection()
        {
            if (connectionString == null)
            {
                throw new Exception("Credentials is empty");
            }

            return new LibraryContext(connectionString);
        }
    }
}
