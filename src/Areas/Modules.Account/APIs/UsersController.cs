using Microsoft.AspNetCore.Mvc;
namespace Modules.Account.APIs
{
    [ApiController]
    [Route("api/v1/Account/[controller]")]
    public class UsersController : BaseController 
    {
        [HttpGet]
        [Route("GetTemp")]
        public IActionResult GetTemp()
        {
            return Ok();
        }
    }
}