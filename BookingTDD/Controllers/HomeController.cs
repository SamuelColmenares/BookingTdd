

namespace BookingTDD.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Linq;
    using BookingTDD.Models;
    using BookingTDD.Services;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MetadataIntegration data = new MetadataIntegration();
            var a = data.InvokeCities("ES");

            List<SelectListItem> cities = new List<SelectListItem>();

            Parallel.ForEach(a, (city) =>
            {
                cities.Add(new SelectListItem { Text = city.NombreAeropuerto, Value = city.CodigoAeropuerto.ToString() });
            });

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
            ViewBag.Cities = cities;
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