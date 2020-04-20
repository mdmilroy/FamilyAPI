using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FamilyListPeople
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Dictionary<Person, string> Relatives { get; set; }

        [Display(Name = "Birthday")]
        public DateTime Birthdate { get; set; }
    }
}
