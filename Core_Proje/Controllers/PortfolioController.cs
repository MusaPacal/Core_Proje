using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Listesi";
            var value = _portfolioService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Ekleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);

            ModelState.Clear();

            if (result.IsValid)
            {
                _portfolioService.TAdd(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Proje Düzenleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Düzenleme";
            var value = _portfolioService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = _portfolioService.TGetById(id);
            _portfolioService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
