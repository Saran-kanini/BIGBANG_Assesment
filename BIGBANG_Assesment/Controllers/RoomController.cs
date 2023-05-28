using BIGBANG_Assesment.Models;
using BIGBANG_Assesment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIGBANG_Assesment.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoom r;
        public RoomController(IRoom r)
        {
            this.r = r;
        }
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return r.GetRoom();
        }

        [HttpGet("{Room_Id}")]
        public Room GetById(int Room_Id)
        {
            return r.GetRoomById(Room_Id);
        }

        [HttpPost]
        public Room PostRoom(Room room)
        {
            return r.PostRoom(room);
        }
        [HttpPut("{Room_Id}")]
        public Room PutRoom(int Room_Id, Room room)
        {
            return r.PutRoom(Room_Id, room);
        }
        [HttpDelete("{Room_Id}")]
        public Room DeleteRoom(int Room_Id)
        {
            return r.DeleteRoom(Room_Id);
        }
        [HttpGet("filterByPrice")]
        public IEnumerable<Room> GetRoomsByPrice(decimal minPrice, decimal maxPrice)
        {
            return r.GetRoomsByPrice(minPrice, maxPrice);
        }

        [HttpGet("countByAvailability")]
        public int GetRoomCountByAvailability(string availability)
        {
            return r.GetRoomCountByAvailability(availability);
        }

    }
}
