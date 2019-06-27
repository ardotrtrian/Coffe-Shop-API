using CoffeShopAPI.DAL.Models;
using System.Collections.Generic;

namespace CoffeShopAPI.DAL.Interfaces
{
    public interface IMenu
    {
        IEnumerable<Menu> GetAllMenus();

        Menu GetMenuById(int id);
    }
}
