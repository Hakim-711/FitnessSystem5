
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FitnessSystem.Models
{
    public class LK_Plan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name_plan { get; set; }
        [Required]
        public int status { get; set; }
    }
}
