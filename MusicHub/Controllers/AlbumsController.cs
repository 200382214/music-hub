
using MusicHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicHub.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {


            // create a mock list of type Albums
            var albums = new List<Album>();

            for(int i =1; i <= 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString() });
            }

            //add albums to viewbag for display
            //ViewBag.albums = albums;

            //pass the stongly typed list directly to the view
            return View(albums);
        }
    }
}