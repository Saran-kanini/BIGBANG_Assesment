using BIGBANG_Assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace BIGBANG_Assesment.Repository
{
    public class RoomRepository:IRoom
    {
        private readonly HotelContext _roomContext;
        public RoomRepository(HotelContext con)
        {
            _roomContext = con;
        }

        public IEnumerable<Room> GetRoom()
        {
            return _roomContext.Rooms.ToList();
        }
        public Room GetRoomById(int Room_Id)
        {
            return _roomContext.Rooms.FirstOrDefault(x => x.Room_Id == Room_Id);
        }

        public Room PostRoom(Room room)
        {
            if (room.Hotel != null)
            {
                var r = _roomContext.Hotels.Find(room.Hotel.Hotel_Id);
                room.Hotel = r;
            }
            _roomContext.Add(room);
            _roomContext.SaveChanges();
            return room;
        }

        public Room PutRoom(int Room_Id, Room room)
        {
            if (room.Hotel != null)
            {
                var r = _roomContext.Hotels.Find(room.Hotel.Hotel_Id);
                room.Hotel = r;
            }
            _roomContext.Entry(room).State = EntityState.Modified;
            _roomContext.SaveChangesAsync();
            return room;
        }


        public Room DeleteRoom(int Room_Id)
        {

            var r = _roomContext.Rooms.Find(Room_Id);


            _roomContext.Rooms.Remove(r);
            _roomContext.SaveChanges();

            return r;
        }
        public IEnumerable<Room> GetRoomsByPrice(decimal minPrice, decimal maxPrice)
        {
            return _roomContext.Rooms
                .Where(room => room.Price >= minPrice && room.Price <= maxPrice)
                .ToList();
        }

        public int GetRoomCountByAvailability(string availability)
        {
            return _roomContext.Rooms
                .Count(room => room.Availability == availability);
        }
    }
}
