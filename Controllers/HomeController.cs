using Microsoft.AspNetCore.Mvc;
using Modules.Account.Models;

namespace StructureMPA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Account account = new Account("TuanKiet", "Kiet@123");

            account.ShowUserTemp();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}