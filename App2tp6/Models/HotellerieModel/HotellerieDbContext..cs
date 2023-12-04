using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace App2tp6.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; } = null;
        public DbSet<Appreciation> Appreciations { get; set; } = null;

    }
}
