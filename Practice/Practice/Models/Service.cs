using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Service
    {

        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Icon { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

    }
}
