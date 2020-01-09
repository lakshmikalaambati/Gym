using System;
using System.Collections.Generic;
using System.Text;
using Gym.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gym.Models.GymClass> GymClass { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<ApplicationUserGymClass>().HasKey(t => new { t.ApplicationUserId, t.GymClassId }); 
        }
    }
}
