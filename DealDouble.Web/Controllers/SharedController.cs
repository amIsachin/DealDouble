using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class SharedController : Controller
    {
        SharedService sharedService = new SharedService();

        [HttpPost]
        public JsonResult UploadPitures()
        {
            JsonResult result = new JsonResult();
            List<object> picturesJSON = new List<object>();

            var pictures = Request.Files;
            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];
                var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                var path = Server.MapPath("~/Content/ThemeMaterial/Images/") + fileName;
                picture.SaveAs(path);

                var dbPicture = new Picture();
                dbPicture.URL = path;
                var pictureID = sharedService.SavePicture(dbPicture);

                picturesJSON.Add(new { ID = pictureID, pictureURL = fileName });
            }

            result.Data = picturesJSON;
            return result;
        }
    }
}