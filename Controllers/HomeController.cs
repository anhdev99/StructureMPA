using Microsoft.AspNetCore.Mvc;
using Modules.Shared.Configurations;

namespace StructureMPA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAppSettingConfigManager _appSettingConfigManager;

        public HomeController(ILogger<HomeController> logger, IAppSettingConfigManager appSettingConfigManager)
        {
            _logger = logger;
            _appSettingConfigManager = appSettingConfigManager;
        }

        public IActionResult Index()
        {
           var connectionString = _appSettingConfigManager.GetConnectionString("Mongodb");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}