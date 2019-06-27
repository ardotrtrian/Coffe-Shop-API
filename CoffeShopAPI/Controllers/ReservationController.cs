using CoffeShopAPI.BLL;
using CoffeShopAPI.BLL.Models;
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
        private ReservationBLL reservationBLL;

        public ReservationController(ReservationBLL reservationBLL)
        {
           this.reservationBLL = reservationBLL;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Reservation reservation)
        {
            var reserve = new ReservationModel()
            {
                Name = reservation.Name,
                Date = reservation.Date,
                Email = reservation.Email,
                Phone = reservation.Phone,
                Time = reservation.Time,
                TotalPeople = reservation.TotalPeople
            };

            bool result = reservationBLL.CreateReservation(reserve);

            if (result)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}