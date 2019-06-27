using CoffeShopAPI.DAL.Interfaces;
using CoffeShopAPI.DAL.Models;
using CoffeShopAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoffeShopAPI.DAL
{
    public class MenuDAL : IMenu
    {
        private EspressoDbContext _db;

        public MenuDAL(EspressoDbContext dbContext)
        {
            _db = dbContext;
        }
        public IEnumerable<Menu> GetAllMenus()
        {
            return _db.Menus.Include(m => m.SubMenus);
        }

        public Menu GetMenuById(int id)
        {
            return _db.Menus.Include(m => m.SubMenus).FirstOrDefault(m => m.Id == id);
        }
    }
}
