using Microsoft.AspNetCore.Mvc;

namespace corefirst_211026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
