using CoffeShopAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
