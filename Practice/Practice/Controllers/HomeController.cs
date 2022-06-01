using Microsoft.AspNetCore.Mvc;
using Practice.DAL;
using Practice.Models;
using Practice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
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
            List<Slider> sliders = _context.Sliders.OrderBy(x=>x.Order).ToList();
            List<Service> services = _context.Services.ToList();
            HomeView homeVW = new HomeView
            {
                Sliders = sliders,
                Services = services
            };
            return View(homeVW);
        }
        
    }
}
