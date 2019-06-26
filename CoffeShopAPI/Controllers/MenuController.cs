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
            var menus = _db.Menus.Include(m => m.SubMenus);  //include("SubMenus") //Eager Loading
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menus = _db.Menus.Include(m => m.SubMenus).FirstOrDefault(m => m.Id == id);  //var menus = _db.Menus.Include("SubMenus").FirstOrDefault(m=>m.Id == id);
            if (menus == null)
            {
                return NotFound("No records found against the Id!");
            }
            return Ok(menus);
        }
    }
}