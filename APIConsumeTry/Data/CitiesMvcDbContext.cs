using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiesLibrary;
using Microsoft.EntityFrameworkCore;

namespace APIConsumeTry.Data;

public class CitiesMvcDbContext : DbContext
{
    public CitiesMvcDbContext(DbContextOptions options) : base(options)
    {
    }

    // public DbSet<City> Cities { get; set;}

    // protected override void OnModelCreating(ModelBuilder modelBuilder) {
    //     modelBuilder.Entity<City>().HasData(
    //         new City {CityId = 1, Name= "Tokyo"}
    //     );
    // }
}
