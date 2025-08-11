using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.ViewComponents
{
    public class _DashboardOverviewPartial:ViewComponent
    {
        AgricultureContext context = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = context.Announcements.Where(x => x.Status == false).Count();

            ViewBag.productSales = context.Teams.Where(x => x.Title == "Salesman").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.milkProducer = context.Teams.Where(x => x.Title == "Milk Producer").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.fieldWorker = context.Teams.Where(x => x.Title == "Field Worker").Select(y=>y.PersonName).FirstOrDefault();
            ViewBag.founder = context.Teams.Where(x => x.Title == "Founder").Select(y=>y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
