using CoffeShopAPI.DAL.Models;

namespace CoffeShopAPI.DAL.Interfaces
{
    public interface IReservation
    {
        bool CreateReservation(Reservation reservation);
    }
}
