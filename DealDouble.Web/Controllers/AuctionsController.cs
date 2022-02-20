using DealDouble.Entities;
using DealDouble.Services;
using DealDouble.Web.ViewModels;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        AuctionsService service = new AuctionsService();

        public ActionResult Index()
        {
            AuctionsListingViewModel model = new AuctionsListingViewModel();
            model.Auctions = service.GetAllAuction();
            model.PageTitle = "Auctions";
            model.PageDescription = "Action Listing Page";
            if (Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet] 
        public ActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            service.SaveAuction(auction);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var Auction = service.GetAuctionByID(ID);
            return PartialView(Auction);
        }

        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            service.UpdateAuction(auction);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            service.DeleteAuction(auction);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int ID)
        {
            return View(service.GetAuctionByID(ID)); 
        }

        public ActionResult Free()
        {
            AuctionsListingViewModel model = new AuctionsListingViewModel();
            model.PageTitle = "Auctions";
            model.PageDescription = "Action Listing Page";
            return View(model);
        }
    }
}