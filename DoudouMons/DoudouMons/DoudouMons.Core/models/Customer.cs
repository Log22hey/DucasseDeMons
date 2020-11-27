using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core.models
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String adresse { get; set; }
        public int numero { get; set; }
        public int cp { get; set; }
        public String ville { get; set; }

        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
