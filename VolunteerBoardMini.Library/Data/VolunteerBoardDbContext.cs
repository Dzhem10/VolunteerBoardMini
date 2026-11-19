using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using VolunteerBoardMini.Data.Entities;

namespace VolunteerBoardMini.Data.Data
{
    public class VolunteerBoardDbContext : DbContext
    {
        public VolunteerBoardDbContext(
            DbContextOptions<VolunteerBoardDbContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteerInitiative> VolunteerInitiatives { get; set; }

        public DbSet<Volunteer> Volunteers { get; set; }

        public DbSet<VolunteerRegistration> VolunteerRegistrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VolunteerRegistration>()
                .HasKey(vr => new { vr.VolunteerId, vr.VolunteerInitiativeId });

            modelBuilder.Entity<VolunteerRegistration>()
                .HasOne(vr => vr.Volunteer)
                .WithMany(v => v.Registrations)
                .HasForeignKey(vr => vr.VolunteerId);

            modelBuilder.Entity<VolunteerRegistration>()
                .HasOne(vr => vr.VolunteerInitiative)
                .WithMany(vi => vi.Registrations)
                .HasForeignKey(vr => vr.VolunteerInitiativeId);
        }
    }
}