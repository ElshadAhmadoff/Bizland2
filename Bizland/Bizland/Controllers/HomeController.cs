using Bizland.DAL;
using Bizland.Models;
using Bizland.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel()
            {
                categories = await db.Categories.ToListAsync(),
                projects=await db.Projects.ToListAsync()
            };
            return View(hvm);
        }
    }
}
