using ComicBookMVC.Data;
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
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            this._comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            return View(_comicBookRepository.GetComicBook(id.Value));   
        }
    }
}