using BIGBANG_Assesment.Models;

namespace BIGBANG_Assesment.Repository
{
    public interface IHotel
    {
        public IEnumerable<Hotel> GetHotel();
        public Hotel GetHotelById(int Hotel_Id);
        public Hotel PostHotel(Hotel hotel);
        public Hotel PutHotel(int Hotel_Id, Hotel hotel);
        public Hotel DeleteHotel(int Hotel_Id);
        IEnumerable<Hotel> SearchHotels(string location);
    }
}
