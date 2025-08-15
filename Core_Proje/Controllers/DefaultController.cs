using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;

        public DefaultController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessagePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessagePartial(Message p)
        {
            p.Date = DateTime.Now;
            p.Status = false;
            _messageService.TAdd(p);
            return RedirectToAction("Index", "Default");
        }

    }
}
