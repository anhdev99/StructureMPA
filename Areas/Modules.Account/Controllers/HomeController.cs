using System.Web.Mvc;

namespace Modules.Account.Controllers
{

    public class HomeController : Controller
    {
        public HomeController() { }


        public ActionResult Index() { return View(); }
    }
}