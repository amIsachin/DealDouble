using DealDouble.Data;
using DealDouble.Entities;

namespace DealDouble.Services
{
    public class AuctionsService
    {
        public void SaveAuction(Auction auction)
        {
            using (var context = new DealDoubleContext())
            {
                context.Auctions.Add(auction);
                context.SaveChanges();
            }
        }
    }
}