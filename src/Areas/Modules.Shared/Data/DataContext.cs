using Modules.Shared.Configurations;
using Modules.Shared.Constants;
using MongoDB.Driver;
namespace Modules.Shared.Data
{
    public class BaseDataContext
    {
        private readonly IAppSettingConfigManager _appSettingConfigManager;
        private IMongoClient _mongoClient = null;
        private IMongoDatabase _context = null;
        public BaseDataContext(IAppSettingConfigManager appSettingConfigManager)
        {
            _appSettingConfigManager = appSettingConfigManager;
            
            // SetupMongoClient
            this.SetupMongoClient();
        }

        private void SetupMongoClient()
        {
            switch (_appSettingConfigManager.GetEnvironment)
            {
                case Constants.ENV.Production:
                {
                    this._mongoClient = new MongoClient(_appSettingConfigManager.GetConnectionString(DatabaseName.MongoDb));
                    
                    break;
                }
                case Constants.ENV.Development:
                {
                    _mongoClient = new MongoClient(_appSettingConfigManager.GetConnectionString(DatabaseName.MongoDbLocal)); 
                    break;
                }
                default:
                {
                    throw new Exception("Evironment not found!");
                }
            }

            if (_mongoClient == null)
            {
                throw new Exception("MongoClient call failed!"); 
            }

            if (string.IsNullOrEmpty(_appSettingConfigManager.GetDatabaseName))
                throw new Exception("Dataname is empty or null!");

            _context = _mongoClient.GetDatabase(_appSettingConfigManager.GetDatabaseName);

            if (_context == null)
                throw new Exception("DataContext is null!");
        }

        public IMongoDatabase Database
        {
            get { return _context; }
        }

        public IMongoClient Client
        {
            get { return _mongoClient; }
        }
    }
}