using DealDouble.Entities;
using System.Collections.Generic;

namespace DealDouble.Web.ViewModels
{
    public class AuctionViewModel
    {
        public List<Auction> AllAuctions { get; set; }
        public List<Auction> PromotedAuctions { get; set; }
    }
}