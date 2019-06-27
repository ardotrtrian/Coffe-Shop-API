using CoffeShopAPI.DAL.Interfaces;
using CoffeShopAPI.DAL.Models;
using CoffeShopAPI.Data;
using System.Transactions;

namespace CoffeShopAPI.DAL
{
    public class ReservationDal : IReservation
    {
        private EspressoDbContext _db;

        public ReservationDal(EspressoDbContext dbContext)
        {
            _db = dbContext;
        }

        public bool CreateReservation(Reservation reservation)
        {
            _db.Reservations.Add(reservation);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
