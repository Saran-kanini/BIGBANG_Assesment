using BIGBANG_Assesment.Models;

namespace BIGBANG_Assesment.Repository
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Reservation>> GetReservations();
        Task<Reservation> GetReservation(int id);
        Task<Reservation> CreateReservation(Reservation reservation);
        Task<bool> UpdateReservation(int id, Reservation reservation);
        Task<bool> DeleteReservation(int id);
    }
}
