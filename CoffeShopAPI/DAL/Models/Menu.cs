using System.Collections.Generic;

namespace CoffeShopAPI.DAL.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public IEnumerable<SubMenu> SubMenus { get; set; }
    }
}
