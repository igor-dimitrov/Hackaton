using System.Web.Mvc;
using Hackathon.DAL;
using Hackathon.ViewModels;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext dataContext = new DataContext();

        public ActionResult Index()
        {
            ShipsAndTerritoriesViewModel shipsAndTerritoriesViewModel = new ShipsAndTerritoriesViewModel()
            {
                Ships = dataContext.GetShipsAndLocationData(),
                PirateTerritories = dataContext.GetPirateTerritories()
            };

            return View(shipsAndTerritoriesViewModel);
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