﻿using Microsoft.EntityFrameworkCore;

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
                    Age = 37,
                    Birthdate = new DateTime(1985, 5, 28),
                    Email = "somemail@email.com",
                    HasHeadShots = false,
                    ImageUrl = "./images/headshots/person1.jpg"

                },
                  new Client
                  {
                      Id = 2,
                      FirstName = "Jessica",
                      LastName = "Haganey",
                      Age = 33,
                      Birthdate = new DateTime(1989, 4, 29),
                      Email = "testemail@aol.com",
                      HasHeadShots = true,
                      ImageUrl = "./images/headshots/person2.jpg"


                  },
                   new Client
                   {
                       Id = 3,
                       FirstName = "Loren",
                       LastName = "Salgado",
                       Age = 42,
                       Birthdate = new DateTime(1980, 8, 10),
                       Email = "anewemail@outlook.com",
                       HasHeadShots = false,
                       ImageUrl = "./images/headshots/person3.jpg"


                   },
                    new Client
                    {
                        Id = 4,
                        FirstName = "Reef",
                        LastName = "Downes",
                        Age = 10,
                        Birthdate = new DateTime(2012, 3, 20),
                        Email = "reefdowns@gmail.com",
                        HasHeadShots = true,
                        ImageUrl = "./images/headshots/person4.jpg"


                    }
                );
        }
        public DbSet<Client> Clients => Set<Client>();
    }
}
