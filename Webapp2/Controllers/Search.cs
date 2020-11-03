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
    public class Search : Controller
    {
        CMMSmartfarmContext db = new CMMSmartfarmContext();
        public IActionResult Index(String query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View("Index", db.Product.ToList());
            }
            else
            {
                return View("Index",db.Product.Where(p=>p.ProductName.Contains(query)).ToList());
            }
        }
    }
}
