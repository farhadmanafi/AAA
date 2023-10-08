using Microsoft.AspNetCore.Mvc;

namespace AAAManagement.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
