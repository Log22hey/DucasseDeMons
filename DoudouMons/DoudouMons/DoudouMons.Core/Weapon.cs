using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core
{
    class Weapon
    {
        public int IdArme { get; set; }
        public string NomArme { get; set; }

        public virtual Character Character { get; set; }
    }
}
