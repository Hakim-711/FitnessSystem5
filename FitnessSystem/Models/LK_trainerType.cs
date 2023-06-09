using System.ComponentModel.DataAnnotations;

namespace FitnessSystem.Models
{
    public class LK_trainerType
    {
        [Key]
        public int Id { get; set; }
        [Required] public string trainerType { get; set; }

    }
}
