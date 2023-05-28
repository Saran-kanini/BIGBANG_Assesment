using System.ComponentModel.DataAnnotations;

namespace BIGBANG_Assesment.Models
{
    public class Hotel
    {
        [Key]
        public int Hotel_Id { get; set; }
        public string? Hotel_Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhNumber { get; set; }
        public string? Hotel_Location { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
