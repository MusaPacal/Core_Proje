using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics: ViewComponent
    {
       Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x=>x.Status==false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.Status ==true).Count();
            ViewBag.v4 = c.Experiences.Count();
            var value = c.Messages.Where(x => x.Status == false).OrderByDescending(x => x.MessageID).FirstOrDefault();
            if (value == null)
            {
                ViewBag.v6 = "Okunmamış Mesaj Yok";
            }
            else
            {
                ViewBag.v6 = value.MessageName+ " Kişisinin Mesajı Var";
            }

            var lastMessage = c.Messages.OrderByDescending(x => x.MessageID).FirstOrDefault();

            if (lastMessage != null)
            {
                ViewBag.v5 = lastMessage.MessageName; 
            }
            else
            {
                ViewBag.v5 = "Mesaj yok";
            }
            return View();
        }
        
    }
}
