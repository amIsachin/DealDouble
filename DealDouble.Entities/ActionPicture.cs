namespace DealDouble.Entities
{
    public class ActionPicture : BaseEntity
    {
        public int AuctionID { get; set; }
        public int PictureID { get; set; }
        public Picture Picture { get; set; }
    }
}
