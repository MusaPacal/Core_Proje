using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda Listesi";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Listesi";
            var value = _aboutService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            ViewBag.v1 = "Hakkımda Ekleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.TAdd(about);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            ViewBag.v1 = "Hakkımda Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            var value = _aboutService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
