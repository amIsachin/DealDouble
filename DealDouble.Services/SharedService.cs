using DealDouble.Data;
using DealDouble.Entities;

namespace DealDouble.Services
{
    public class SharedService
    {
        public int SavePicture(Picture picture)
        {
            using (var context = new DealDoubleContext())
            {
                context.Pictures.Add(picture);
                context.SaveChanges();
                return picture.ID;
            }
        }
    }
}
