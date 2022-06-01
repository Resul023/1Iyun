using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Desc { get; set; }
        public Categories Category { get; set; }

    }
}
