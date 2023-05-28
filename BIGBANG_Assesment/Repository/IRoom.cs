using BIGBANG_Assesment.Models;

namespace BIGBANG_Assesment.Repository
{
    public interface IRoom
    {
        public IEnumerable<Room> GetRoom();
        public Room GetRoomById(int Room_Id);
        public Room PostRoom(Room room);
        public Room PutRoom(int Room_Id, Room room);
        public Room DeleteRoom(int Room_Id);
        IEnumerable<Room> GetRoomsByPrice(decimal minPrice, decimal maxPrice);
        int GetRoomCountByAvailability(string availability);
    }
}
