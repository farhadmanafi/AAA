using Microsoft.AspNetCore.Mvc;

namespace AAAManagement.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            var a = User.Identities;
            return View();
        }
    }
}
