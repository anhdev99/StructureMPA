using Modules.Account.Models;
using Modules.Shared.Configurations;
using Modules.Shared.Data;
using MongoDB.Driver;
namespace Modules.Account.Data
{
    public class DataContext : BaseDataContext
    {
        private readonly IMongoCollection<User> _users;
        private readonly IMongoCollection<Role> _roles;
        private readonly IMongoCollection<Module> _modules;
        private readonly IMongoCollection<Permission> _permissions;
        private readonly IMongoCollection<Menu> _menu;

        public DataContext(IAppSettingConfigManager appSettingConfigManager) : base(appSettingConfigManager)
        {
            _users = Database.GetCollection<User>("User");
            _roles = Database.GetCollection<Role>("Role");
            _modules = Database.GetCollection<Module>("Module");
            _permissions = Database.GetCollection<Permission>("Permission");
            _menu = Database.GetCollection<Menu>("Menu");
        }
        
        public IMongoCollection<User> Users { get => _users; }
        public IMongoCollection<Role> Roles { get => _roles; }
        public IMongoCollection<Module> Modules { get => _modules; }
        public IMongoCollection<Permission> Permissions { get => _permissions; }
        public IMongoCollection<Menu> Menu { get => _menu; }
    }
}