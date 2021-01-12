using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.models
{
    class ProductDetailDTO
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public String Desc { get; set; }
        public float prix { get; set; }
        public int Stockquantity { get; set; }
    }
}
