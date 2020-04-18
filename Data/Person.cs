using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Vehicle { get; set; }
        public bool Married { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentState { get; set; }
        public List<string> StatesLivedIn { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public string Occupation { get; set; }
        public bool IsVeteran { get; set; }
    }
}
