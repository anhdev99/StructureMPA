namespace Modules.Shared.Configurations
{
    using Microsoft.Extensions.Configuration;
    public interface IAppSettingConfigManager
    {
        string GetConnectionString(string connectionName);

        string GetDatabaseName { get; }
        
        string GetEnvironment { get; }
        
        IConfigurationSection GetConfigurationSection(string Key);
        
        string AccountKey { get; }
        string EmailId { get; }
    }
}