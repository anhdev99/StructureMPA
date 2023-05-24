using Microsoft.Extensions.Configuration;
namespace Modules.Shared.Configurations
{
    public interface IAppSettingConfigManager
    {
        string GetConnectionString(string connectionName);

        string GetDatabaseName { get; }
        
        IConfigurationSection GetConfigurationSection(string Key);
        
        string AccountKey { get; }
        string EmailId { get; }
    }
}