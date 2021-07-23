using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using News.Models;

namespace News.Controllers
{
    public class NewsModelsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: NewsModels
        public ActionResult Index()
        {
            return View(db.newsModels.ToList());
        }

    }
}
