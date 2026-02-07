using Microsoft.EntityFrameworkCore;
using TrainTime_Database.Entities;

namespace TrainTime_Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<BookedTraining> BookedTrainings { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<GymWorkingPeriod> GymWorkingPeriods { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerWorkingPeriod> TrainerWorkingPeriods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGym> UserGyms { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.UserCredentials)
                .WithOne(uc => uc.User)
                .HasForeignKey<UserCredentials>(uc => uc.UserId);

            modelBuilder.Entity<User>().HasOne(u => u.UserDetails)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserDetails>(ud => ud.UserId);

            modelBuilder.Entity<User>().HasMany(u => u.BookedTrainings)
                .WithOne(bt => bt.User)
                .HasForeignKey(bt => bt.UserId);

            modelBuilder.Entity<User>().HasMany(u => u.UserGyms)
                .WithOne(ug => ug.User)
                .HasForeignKey(ug => ug.UserId);

            modelBuilder.Entity<Gym>().HasMany(g => g.UserGyms)
                .WithOne(ug => ug.Gym)
                .HasForeignKey(ug => ug.GymId);

            modelBuilder.Entity<Gym>().HasMany(g => g.WorkingPeriods)
                .WithOne(wp => wp.Gym)
                .HasForeignKey(w => w.GymId);

            modelBuilder.Entity<Trainer>().HasMany(t => t.WorkingPeriods)
                .WithOne(wp => wp.Trainer)
                .HasForeignKey(wp => wp.TrainerId);

            modelBuilder.Entity<UserDetails>().HasOne(ud => ud.Trainer)
                .WithOne(t => t.UserDetails).HasForeignKey<Trainer>(t => t.UserDetailsId)
                .IsRequired(false);

            modelBuilder.Entity<UserGym>()
                .HasIndex(ug => new { ug.UserId, ug.GymId })
                .IsUnique();
        }
    }
}
