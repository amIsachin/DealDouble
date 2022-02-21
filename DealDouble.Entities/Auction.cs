using System;
using System.Collections.Generic;

namespace DealDouble.Entities
{
    public class Auction : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }

        public List<ActionPicture> ActionPictures { get; set; }
    }
}
