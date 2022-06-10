using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
