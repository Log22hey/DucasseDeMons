using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.models
{
    class Products
    {
        [Key]
        public int idProduct { get; set; }
        public String name { get; set; }
        public float prix { get; set; }
    }
}
