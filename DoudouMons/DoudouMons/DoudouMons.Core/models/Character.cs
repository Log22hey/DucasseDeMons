using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core
{
    public class Character
    {
        [Key]
        public int IdCharacter { get; set; }
        public string Name { get; set; }
        public String costume{ get; set; }
        public String ExplicationRole { get; set; }
        public String NomArmes { get; set; }

        public virtual Weapon Weapon { get; set; }
        public virtual Role Role { get; set; }
    }
}
