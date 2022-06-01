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
    public class ServiceController : Controller
    {
        public AppDbContext _context;
        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            ServiceView service = new ServiceView
            {
                Services = services,
            };
            return View(service);
        }
        public IActionResult Detail(int id)
        {

            Service service = _context.Services.FirstOrDefault(x => x.Id == id);
            return View(service);
        }
    }
}
