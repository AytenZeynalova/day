using DAYbackend.DAL;
using DAYbackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAYbackend.Areas.Manage.Controllers
{
    [Area("manage")]
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

        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Create(Team team)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            
            _context.Teams.Add(team);
            _context.SaveChanges();


            return RedirectToAction("index");

        }


        public IActionResult Edit(int id)
        {

            return View();
        }










    }
}
