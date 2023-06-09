using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FitnessSystem.Models
{
    public class Feedback
    {

        [Required(ErrorMessage = "  is required")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "  is required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "  is required")]
        public string Message { get; set; }
        [Required(ErrorMessage = "  is required")]
        public int Likelihood { get; set; }

    }
}
