using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard Sayfası";
            ViewBag.v2 = "Dashboard";
            ViewBag.v3 = "Dashboard Sayfası";
            return View();
        }
    }
}
