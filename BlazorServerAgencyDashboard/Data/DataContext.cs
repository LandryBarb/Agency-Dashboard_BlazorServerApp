using Microsoft.EntityFrameworkCore;

namespace BlazorServerAgencyDashboard.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    FirstName = "Landry",
                    LastName = "Barb",
                    Age = 36,
                    Birthdate = new DateTime(1985, 5, 28),
                    Email = "contact@landrybarb.com",
                    HasHeadShots = false

                },
                  new Client
                  {
                      Id = 2,
                      FirstName = "Jessica",
                      LastName = "Haganey",
                      Age = 33,
                      Birthdate = new DateTime(1989, 4, 29),
                      Email = "jessie.haganey@aol.com",
                      HasHeadShots = true

                  }
                );
        }
        public DbSet<Client> Clients => Set<Client>();
    }
}
