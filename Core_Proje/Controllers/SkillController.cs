using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenekler Listesi";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenekler Listesi";
            var  values= _skillService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenekler Ekleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenekler Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillService.TAdd(skill);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            ViewBag.v1 = "Yetenekler Güncelleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenekler Güncelleme";
            var value = _skillService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _skillService.TUpdate(skill);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = _skillService.TGetById(id);
            _skillService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
