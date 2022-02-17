using DealDouble.Data;
using DealDouble.Entities;
using System.Collections.Generic;
using System.Linq;

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

        public Auction GetAuctionByID(int ID)
        {
            using (var context = new DealDoubleContext())
            {
                return context.Auctions.Find(ID);
            }
        }

        public void UpdateAuction(Auction auction)
        {
            using (var context = new DealDoubleContext())
            {
                context.Entry(auction).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Auction> GetAllAuction()
        {
            using (var context = new DealDoubleContext())
            {
                return context.Auctions.ToList();
            }
        }

        public void DeleteAuction(Auction auction)
        {
            using (var context = new DealDoubleContext())
            {
                context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}