using DealDouble.Entities;
using System.Collections.Generic;

namespace DealDouble.Web.ViewModels
{
    public class AuctionsListingViewModel : PageViewModel
    {
        public List<Auction> Auctions { get; set; }
    }

    public class AuctionViewModel : PageViewModel
    {
        public List<Auction> AllAuctions { get; set; }
        public List<Auction> PromotedAuctions { get; set; }
    }
}