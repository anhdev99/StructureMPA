
namespace Modules.Shared.Configurations
{
    using Microsoft.Extensions.Configuration;
    public class AppSettingConfigManager : IAppSettingConfigManager
    {
        private readonly IConfiguration _configuration;
        public AppSettingConfigManager(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }
        
        public string GetDatabaseName
        {
            get
            {
                return this._configuration["DatabaseSettings:DatabaseName"];
            }
        }
        
        public string AccountKey
        {
            get
            {
                return this._configuration["AppSeettings:AccountKey"];
            }
        }
        public string EmailId 
        {
            get
            {
                return this._configuration["AppSeettings:EmailID"];
            }
        }

        public string GetEnvironment
        {
            get
            {
                return this._configuration["AppSeettings:Environment"];
            }
        }
        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }

    }
}