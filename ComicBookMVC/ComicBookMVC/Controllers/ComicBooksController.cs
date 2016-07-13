using ComicBookMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookMVC.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ComicBook comicBook = new ComicBook();
            comicBook.SeriesTitle = "The Amazing Spider-Man";
            comicBook.IssueNumber = 700;
            comicBook.DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            Artist[] artists =
                {
                    new Artist() {Name = "Dan Slott", Role = "Script" },
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() {Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() {Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters" }
                };
            comicBook.Artists = artists;

            
            return View(comicBook);   
        }
    }
}