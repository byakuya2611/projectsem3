using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class TouristSpotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
