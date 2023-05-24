using Microsoft.AspNetCore.Mvc;
using Modules.Shared.Configurations;

namespace Modules.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        private IAppSettingConfigManager _appSettingConfigManager;
        public HomeController(IAppSettingConfigManager appSettingConfigManager)
        {
            _appSettingConfigManager = appSettingConfigManager;

        }


        public ActionResult Index()
        {
            var connectionString = _appSettingConfigManager.GetConnectionString("Mongodb");
            return View();
        }
    }
}