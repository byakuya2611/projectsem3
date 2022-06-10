using Microsoft.EntityFrameworkCore;
using PJ3.Data;

namespace PJ3.Repo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccommodationType> AccommodationTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pakage> Pakages { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }
        public DbSet<TouristSpot> TouristSpots { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}