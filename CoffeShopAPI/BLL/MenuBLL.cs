using CoffeShopAPI.BLL.Models;
using CoffeShopAPI.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CoffeShopAPI.BLL
{
    public class MenuBLL
    {
        private IMenu MenuDAL;

        public MenuBLL(IMenu menuDal)
        {
            MenuDAL = menuDal;
        }

        public List<MenuModel> GetAllMenus()
        {
            return MenuDAL.GetAllMenus().Select(menu => new MenuModel
            {
                Id = menu.Id,
                Image = menu.Image,
                Name = menu.Name,
                SubMenus = menu.SubMenus.Select(subMenu => new SubMenu
                {
                    Id = subMenu.Id,
                    Description = subMenu.Description,
                    Name = subMenu.Name,
                    Image = subMenu.Image,
                    Price = subMenu.Price
                })
            }).ToList();
        }

        public MenuModel GetMenuById(int id)
        {
            var menu = MenuDAL.GetMenuById(id);

            return new MenuModel
            {
                Id = menu.Id,
                Image = menu.Image,
                Name = menu.Name,
                SubMenus = menu.SubMenus.Select(subMenu => new SubMenu
                {
                    Id = subMenu.Id,
                    Description = subMenu.Description,
                    Name = subMenu.Name,
                    Image = subMenu.Image,
                    Price = subMenu.Price
                })
            };
        }
    }
}
