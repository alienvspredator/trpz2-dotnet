using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using WpfApp4.Models;

namespace WpfApp4.Core.Service
{
    /// <summary>
    /// Сервис управления подключением
    /// </summary>
    public static class DbConnectionService
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

        /// <summary>
        /// Устанавливает данные подключения к БД
        /// </summary>
        /// <param name="username">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        public static void SetCredentials(string username, string password)
        {
            connectionString = BuildCredentials(username, password);
        }

        /// <summary>
        /// Тест подключения к БД
        /// </summary>
        /// <param name="context">Контекст БД</param>
        /// <returns>Установлено ли подключение</returns>
        public static bool TestConnection(DbContext context)
        {
            return context.Database.Exists();
        }

        /// <summary>
        /// Генерирует подключение к БД по установленным данным в SetCredentials
        /// </summary>
        /// <returns>Подключение к БД библиотеки</returns>
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
