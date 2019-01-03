

namespace BookingTDD.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Linq;
    using BookingTDD.Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> passangersList = new List<SelectListItem>();
            for (int i = 0; i < 10; i++)
            {
                passangersList.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }

            SelectListItem[] adultList = new SelectListItem[passangersList.Count];
            passangersList.CopyTo(adultList);
            ViewBag.ListPas = adultList;
            passangersList.RemoveAt(0);
            ViewBag.ListAdt = passangersList;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Booking model)
        {
            List<SelectListItem> passangersList = new List<SelectListItem>();
            for (int i = 0; i < 10; i++)
            {
                passangersList.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }

            SelectListItem[] adultList = new SelectListItem[passangersList.Count];
            passangersList.CopyTo(adultList);
            ViewBag.ListPas = adultList;
            passangersList.RemoveAt(0);
            ViewBag.ListAdt = passangersList;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}