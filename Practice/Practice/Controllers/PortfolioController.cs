using Microsoft.AspNetCore.Mvc;
using Practice.DAL;
using Practice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var portfolios = _context.Portfolios.ToList();
            var category = _context.Categories.ToList();
            PortfolioView newPort = new PortfolioView
            {
            
                Portfolios = portfolios,
                Category = category
            };
            return View(newPort);
        }
    }
}
