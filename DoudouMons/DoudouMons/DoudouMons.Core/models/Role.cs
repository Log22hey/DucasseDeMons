using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudouMons.Core
{
    public class Role
    {
        public int IdRole { get; set; }
        public string ExlicationRole { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
