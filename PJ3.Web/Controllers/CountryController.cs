using Microsoft.AspNetCore.Mvc;

namespace PJ3.Web.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
