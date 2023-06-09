using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace FitnessSystem.Models
{
    public class RegisterFormTrainer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = " Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone number is required")]

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "your Experience is required")]

        public string Experience { get; set; }
        [Required(ErrorMessage = "Trainer Type is required")]

        public int TrainerType { get; set; }



        // Add other properties for the form fields as needed
    }
}
