using Microsoft.AspNetCore.Mvc;
namespace Modules.FileManager.Controllers
{
    [Area("FileManager")]
    public class HomeController : Controller
    {
        public HomeController() { }


        public ActionResult Index() { return View(); }
    }
}