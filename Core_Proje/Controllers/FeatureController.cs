using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Feature Listesi";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Feature Listesi";
            var value = _featureService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddFeature()
        {
            ViewBag.v1 = "Feature Ekleme";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Feature Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddFeature(Feature feature)
        {
            _featureService.TAdd(feature);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            ViewBag.v1 = "Feature Düzenleme";
            ViewBag.v2 = "Feature";
            ViewBag.v3 = "Feature Düzenleme";
            var value = _featureService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
