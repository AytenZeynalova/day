using DAYbackend.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAYbackend.Controllers
{
    
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var data = _context.Teams.ToList();
            return View(data);
        }
    }
}
