using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.models
{
    class Shopping
    {
        [Key]
        public int idShopping { get; set; }
        public int idCustomer { get; set; }
        public int idProduct { get; set; }
    }
}
