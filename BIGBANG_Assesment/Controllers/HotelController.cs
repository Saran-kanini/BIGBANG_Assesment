using BIGBANG_Assesment.Models;
using BIGBANG_Assesment.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BIGBANG_Assesment.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel ht;
        public HotelController(IHotel hot)
        {
            this.ht = hot;
        }
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            return ht.GetHotel();
        }

        [HttpGet("{HotelId}")]
        public Hotel GetById(int HotelId)
        {
            return ht.GetHotelById(HotelId);
        }

        [HttpPost]
        public Hotel PostHotel(Hotel hotel)
        {
            return ht.PostHotel(hotel);
        }
        [HttpPut("{HotelId}")]
        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            return ht.PutHotel(HotelId, hotel);
        }
        [HttpDelete("{HotelId}")]
        public Hotel DeleteHotel(int HotelId)
        {
            return ht.DeleteHotel(HotelId);
        }
        [HttpGet("search")]
        public IEnumerable<Hotel> SearchHotels(string location)
        {
            return ht.SearchHotels(location);
        }

    }
}
