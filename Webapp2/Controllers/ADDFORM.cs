using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webapp2.Models;
using Webapp2.Model.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Webapp2.Controllers
{
    public class ADDFORM : Controller
    {
        CMMSmartfarmContext db = new CMMSmartfarmContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index (Product product)
        {
            if (ModelState.IsValid)
            {
                db.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Tablelist));
            }
            return View(product);
        }
        public IActionResult Tablelist()
        {
            var ps = from p in db.Product select p;
            return View(ps);
        }
    }
}
