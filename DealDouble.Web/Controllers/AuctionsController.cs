using DealDouble.Entities;
using DealDouble.Services;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionsService service = new AuctionsService();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            service.SaveAuction(auction);
            return View();
        }
    }
}