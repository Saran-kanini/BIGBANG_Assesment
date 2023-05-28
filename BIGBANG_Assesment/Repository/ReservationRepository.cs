using BIGBANG_Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace BIGBANG_Assesment.Repository
{
    public class ReservationRepository:IReservationRepository
    {
        private readonly HotelContext _context;

        public ReservationRepository(HotelContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> GetReservations()
        {
            return await _context.Reservations.Include(x => x.Customer).ToListAsync();
        }

        public async Task<Reservation> GetReservation(int id)
        {
            return await _context.Reservations.FindAsync(id);
        }

        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
            return reservation;
        }

        public async Task<bool> UpdateReservation(int id, Reservation reservation)
        {
            if (id != reservation.Reservation_Id)
                return false;

            _context.Entry(reservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> DeleteReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
                return false;

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
