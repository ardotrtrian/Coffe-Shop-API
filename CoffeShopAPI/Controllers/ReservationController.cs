using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShopAPI.Data;
using CoffeShopAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private EspressoDbContext _db;

        public ReservationController(EspressoDbContext espressoDbContext)
        {
            _db = espressoDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _db.Reservations.Add(reservation);
            _db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}