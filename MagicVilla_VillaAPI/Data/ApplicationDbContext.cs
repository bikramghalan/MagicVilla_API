using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa>Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = " The villa is situated in a prime location, such as a beachfront property, a scenic hilltop, or in the heart of a vibrant city",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 2,
                     Name = "Beachside Villa",
                     Details = " A luxurious villa with a stunning view of the beach",
                     ImageUrl = "",
                     Occupancy = 4,
                     Rate = 300,
                     Sqft = 850,
                     Amenity = "",
                     CreatedDate = DateTime.Now
                 },
                  new Villa()
                  {
                      Id = 3,
                      Name = "Hilltop Villa",
                      Details = " A peaceful villa surrounded by greenery and stunning views",
                      ImageUrl = "",
                      Occupancy = 4,
                      Rate = 300,
                      Sqft = 850,
                      Amenity = "",
                      CreatedDate=DateTime.Now
                  },
                   new Villa()
                   {
                       Id = 4,
                       Name = "Luxury Villa",
                       Details = " A lavish villa with modern amenities and premium furnishings",
                       ImageUrl = "",
                       Occupancy = 4,
                       Rate = 300,
                       Sqft = 850,
                       Amenity = "",
                       CreatedDate=DateTime.Now
                   }
                );
        }
    }
}