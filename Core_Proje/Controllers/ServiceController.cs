using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetlerim Listesi";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmetlerim Listesi";
            var values = _serviceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.v1 = "Hizmet Ekleme";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TAdd(service);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            ViewBag.v1 = "Hizmet Düzenleme";
            ViewBag.v2 = "Hizmetlerim";
            ViewBag.v3 = "Hizmet Düzenleme";
            var value = _serviceService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
