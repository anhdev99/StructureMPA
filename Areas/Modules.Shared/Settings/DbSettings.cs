namespace Modules.Shared.Settings
{
    public interface IDbSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string Environment { get; set; }
    }
    
    public class DbSettings : IDbSettings
    {
        public string ConnectionString { get; set; } 
        public string DatabaseName { get; set; }
        public string Environment { get; set; }
    }
}