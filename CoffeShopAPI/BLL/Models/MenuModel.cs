using System.Collections.Generic;

namespace CoffeShopAPI.BLL.Models
{
    public class MenuModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public IEnumerable<SubMenu> SubMenus { get; set; }
    }
}
