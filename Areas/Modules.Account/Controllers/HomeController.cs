using Microsoft.AspNetCore.Mvc;

namespace Modules.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}