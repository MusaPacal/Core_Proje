using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyimler Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Listesi";
            var values = _experienceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyimler Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceService.TAdd(experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperinece(int id)
        {
            ViewBag.v1 = "Deneyimler Düzenleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyimler Düzenleme";
            var value = _experienceService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperinece(Experience experience)
        {
            _experienceService.TUpdate(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = _experienceService.TGetById(id);
            _experienceService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
