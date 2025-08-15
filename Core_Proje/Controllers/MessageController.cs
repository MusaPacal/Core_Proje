using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var value = _messageService.TGetList();
            return View(value);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult GetMessageDetails(int id)
        {
            var value = _messageService.TGetById(id);
            if (!value.Status)
            {
                value.Status = true;
                _messageService.TUpdate(value);
            }

            return View(value);
        }
        
    }
}
