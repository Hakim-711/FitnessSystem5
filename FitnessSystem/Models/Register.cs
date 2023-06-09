using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessSystem.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public int GenderID { get; set; }

        [Required(ErrorMessage = "Current Weight is required")]
        public int CurrentWeight { get; set; }

        [Required(ErrorMessage = "Desired Weight is required")]
        public int DesiredWeight { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }

        public int BMI { get; set; }

        [Required(ErrorMessage = "Home Address is required")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip Code/Postal is required")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public int Country { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a plan")]
        public int Plan { get; set; }

        public bool Agree { get; set; }
        [ForeignKey("GenderID")]
        public virtual LK_Gender Gender { get; set; }

        [ForeignKey("Country")]
        public virtual LK_countries CountryNavigation { get; set; }

        [ForeignKey("Plan")]
        public virtual LK_Plan PlanNavigation { get; set; }


    }
}
