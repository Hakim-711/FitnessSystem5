using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessSystem.Areas.Identity.Data;
using FitnessSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessSystem.Data
{
    public class FitnessSystemContext : IdentityDbContext<FitnessSystemUser>
    {
        public FitnessSystemContext(DbContextOptions<FitnessSystemContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
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
