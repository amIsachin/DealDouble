using DealDouble.Services;
using DealDouble.Web.ViewModels;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class HomeController : Controller
    {
        private AuctionsService service = new AuctionsService();
        public ActionResult Index()
        {
            AuctionViewModel model = new AuctionViewModel();
            model.PageTitle = "Home Page";
            model.PageDescription = "This is Home page";

            model.AllAuctions = service.GetAllAuction();
            model.PromotedAuctions = service.GetPromotedAuction();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Home application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}