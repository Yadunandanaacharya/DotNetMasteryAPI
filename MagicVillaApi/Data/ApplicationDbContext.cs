using MagicVillaApi.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "npst nsdf nasdf asd asd asdf asdf",
                    Rate = 55,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "test.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa2",
                    Details = "npst nsdf nasdf asd asd asdf asdf",
                    Rate = 55,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "test.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa3",
                    Details = "npst nsdf nasdf asd asd asdf asdf",
                    Rate = 55,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "test.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa4",
                    Details = "npst nsdf nasdf asd asd asdf asdf",
                    Rate = 55,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "test.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Royal Villa5",
                    Details = "npst nsdf nasdf asd asd asdf asdf",
                    Rate = 55,
                    Occupancy = 5,
                    Sqft = 550,
                    ImageUrl = "test.jpg",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
