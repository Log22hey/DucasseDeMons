using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.models
{
    public class Product
    {
        [Key]
        public int idProduct { get; set; }
        public String name { get; set; }
        public string Desc { get; set; }
        public float prix { get; set; }

        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
