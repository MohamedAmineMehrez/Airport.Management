using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;


namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {   public DbSet<Passenger> passengers { get; set; }
        public DbSet<Flight> flights { get; set; }
        public DbSet<Plane> planes { get; set; }
        public DbSet<Traveller> travelllers { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source =(localdb)\mssqllocaldb;

                        Initial catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
            .Properties<DateTime>()
            .HaveColumnType("DateTime2");

        }
    
}
}
