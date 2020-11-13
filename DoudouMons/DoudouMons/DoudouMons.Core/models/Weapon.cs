using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core
{
    public class Weapon
    {
        [Key]
        public int IdArme { get; set; }
        public string NomArme { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
