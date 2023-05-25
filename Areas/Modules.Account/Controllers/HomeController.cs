using Microsoft.AspNetCore.Mvc;
using Modules.Account.Data;
using Modules.Account.Models;

namespace Modules.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var user = new User();
            user.UserName = "anhdev99";
            user.FirstName = "Kiệt";
            user.LastName = "Nguyễn Tuấn";
            
            _context.Users.InsertOne(user);
            return View();
        }
    }
}