using CoffeShopAPI.BLL.Models;
using CoffeShopAPI.DAL.Interfaces;
using CoffeShopAPI.DAL.Models;
namespace CoffeShopAPI.BLL
{
    public class ReservationBLL
    {
        private IReservation reservationDAL;

        public ReservationBLL(IReservation reservationdal)
        {
            reservationDAL = reservationdal;
        }

        public bool CreateReservation(ReservationModel reservationModel)
        {
            var Reservation = new Reservation
            {
                Name = reservationModel.Name,
                Phone = reservationModel.Phone,
                Time = reservationModel.Time,
                TotalPeople = reservationModel.TotalPeople,
                Date = reservationModel.Date,
                Email = reservationModel.Email
            };

            bool result = reservationDAL.CreateReservation(Reservation);

            return result;
        }
    }
}
