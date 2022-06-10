using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class AccommodationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
