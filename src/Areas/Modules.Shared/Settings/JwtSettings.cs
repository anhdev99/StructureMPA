namespace Modules.Shared.Settings
{
    public interface IJwtSettings
    {
        string TokenLifeTime { get; set; }
        string TokenRefreshStore { get; set; }
        string Secret { get; set; }
        string OthersTokenLife { get; set; }
    }
    
    public class JwtSettings : IJwtSettings
    {
        public string TokenLifeTime { get; set; }
        public string TokenRefreshStore { get; set; }
        public string Secret { get; set; }
        public string OthersTokenLife { get; set; }
    }
}