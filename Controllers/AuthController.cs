using Microsoft.AspNetCore.Mvc;
namespace StructureMPA.Controllers
{
    public class AuthController : Controller
    {
        public AuthController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}