using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private EspressoDbContext _db;
        public MenuController(EspressoDbContext espressoDbContext)
        {
            _db = espressoDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menus = _db.Menus.Include(menu=>menu.SubMenus);
            return Ok(menus);
        }
    }
}