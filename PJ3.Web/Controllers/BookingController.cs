using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
