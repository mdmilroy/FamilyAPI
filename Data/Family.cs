using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Family
    {
        public string Name { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }
        public int NumberOfChildren { get; set; }
        public bool HasPets { get; set; }
        public string Church { get; set; }
    }
}
