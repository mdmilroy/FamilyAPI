using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class AddPerson
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        public DateTime Birthdate { get; set; }

        [Required]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Required]
        public bool Married { get; set; }

        [Required]
        public string Occupation { get; set; }

        [Required]
        [Display(Name = "Veteran Status")]
        public bool IsVeteran { get; set; }


        [Display(Name = "Height in inches")]
        public double Height { get; set; }

        [Display(Name = "Weight in lbs")]
        public int Weight { get; set; }
        public string Vehicle { get; set; }
        public string StreetAddress { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentState { get; set; }
        public List<string> StatesLivedIn { get; set; }
    }
}
