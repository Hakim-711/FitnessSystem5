using FitnessSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace FitnessSystem.Data
{
    public class FitnesSystemContext : DbContext
    {
        public FitnesSystemContext(DbContextOptions<FitnesSystemContext> options)
            : base(options)
        {
        }

        public DbSet<FitnessSystem.Models.Register> Register { get; set; } = default!;

        public DbSet<FitnessSystem.Models.Contact> Contact { get; set; } = default!;

        public DbSet<FitnessSystem.Models.RegisterFormTrainer> RegisterFormTrainer { get; set; } = default!;

        public DbSet<FitnessSystem.Models.Feedback> Feedback { get; set; } = default!;
        public DbSet<LK_Gender> LK_Gender { get; set; }
        public DbSet<LK_Plan> LK_Plan { get; set; }
        public DbSet<LK_countries> LK_countries { get; set; }
        public DbSet<LK_trainerType> LK_trainerType { get; set; } = default!;
    }
}
