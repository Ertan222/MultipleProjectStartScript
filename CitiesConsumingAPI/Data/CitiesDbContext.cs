using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesLibrary;
using Microsoft.EntityFrameworkCore;

namespace CitiesConsumingAPI.Data;

public class CitiesDbContext : DbContext
{
    public CitiesDbContext(DbContextOptions<CitiesDbContext> options) : base(options)
    {}

    public DbSet<City> Cities { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<City>().HasData(
            new City {CityId = 1, Name= "Tokyo"},
            new City {CityId = 2, Name= "Tokyo"},
            new City {CityId = 3, Name= "Tokyo"},
            new City {CityId = 4, Name= "Tokyo"},
            new City {CityId = 5, Name= "Tokyo"},
            new City {CityId = 6, Name= "Tokyo"},
            new City {CityId = 7, Name= "Tokyo"},
            new City {CityId = 8, Name= "Tokyo"},
            new City {CityId = 9, Name= "Tokyo"}
            
        );
    }
}
