using Microsoft.EntityFrameworkCore;
//----------------------------
using CoffeShopAPI.DAL.Models;
//----------------------------

namespace CoffeShopAPI.Data
{
    public class EspressoDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public EspressoDbContext(DbContextOptions<EspressoDbContext> options):base(options)
        {

        }
    }
}
