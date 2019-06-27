using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace DennisEFDemoes_ConsoleApp
{
    public sealed class ConnectionStringProvider
    {
        private static readonly ConnectionStringProvider staticSingletonInstance = new ConnectionStringProvider();
        private string connectionStr;
        public string ConnectionStr { get => this.connectionStr; }
        private ConnectionStringProvider()
        {
            connectionStr = GetConnectionString();
        }
        public static ConnectionStringProvider GetInstance()
        {
            return staticSingletonInstance;
        }
        private static string GetConnectionString()
        {
            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string serverName = @"stcav-235\stcav235";
            string databaseName = "EF6Recipes";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.UserID = "sa";
            sqlBuilder.Password = "1qaz2wsxE";

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder =
                new EntityConnectionStringBuilder();

            //Set the provider name.
            //entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;

            // Set the Metadata location.
            //entityBuilder.Metadata = @"res://*/Ef6RecipesContext.csdl|res://*/Ef6RecipesContext.ssdl|res://*/Ef6RecipesContext.msl";
            Console.WriteLine(entityBuilder.ToString());

            return providerString;
        }
    }
}
