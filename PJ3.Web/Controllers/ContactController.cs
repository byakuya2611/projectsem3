using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
