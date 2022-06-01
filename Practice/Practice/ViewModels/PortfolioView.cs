using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.ViewModels
{
    public class PortfolioView
    {
        public List<Categories> Category { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
