using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PT.Models;

namespace PT.Controllers
{
    public class HomeController : Controller
    {
        private readonly PTContext _db;
        public HomeController(PTContext db)
        {
            _db = db;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            List<Treat> treatsModel = _db.Treats.ToList();
            List<Flavor> flavorsModel = _db.Flavors.ToList();
            model.Add("treats", treatsModel);
            model.Add("flavors", flavorsModel);
            return View(model);
        }
    }
}
