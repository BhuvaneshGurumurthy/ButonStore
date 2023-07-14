namespace ButonStore.SharedLibrary
{
    public class AppSettingConstants
    {
        private static string connectionString;

        public static string ConnectionString { get { return connectionString; } }

        static AppSettingConstants()
        {
            GetValueFromAppsettings(GetConfiguration());
        }
        public static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
            return builder.Build();
        }
        public static void GetValueFromAppsettings(IConfiguration configuration)
        {
            connectionString = configuration.GetSection("ConnectionStrings").GetSection("ButonStoreContext").Value;
        }
    }

}
