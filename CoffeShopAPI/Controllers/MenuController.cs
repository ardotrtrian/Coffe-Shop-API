using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShopAPI.BLL;
using CoffeShopAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private MenuBLL menuBLL;
        public MenuController(MenuBLL menuBLL)
        {
            this.menuBLL = menuBLL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menus = menuBLL.GetAllMenus();
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = menuBLL.GetMenuById(id);
            if (menu == null)
            {
                return NotFound("No records found against the Id!");
            }
            return Ok(menu);
        }
    }
}