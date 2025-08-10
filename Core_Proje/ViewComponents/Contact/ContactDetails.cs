using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails: ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactDetails(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _contactService.TGetList();
            return View(value);
        }
    }
}
