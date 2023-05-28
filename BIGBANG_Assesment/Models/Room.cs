using System.ComponentModel.DataAnnotations;

namespace BIGBANG_Assesment.Models
{
    public class Room
    {
        [Key]
        public int? Room_Id { get; set; }
        [Required]
        public string? Room_Number { get; set; }
        public string? Room_Type { get; set; }
        [Range(1, 10)]
        public int? Capacity { get; set; }
        public decimal? Price { get; set; }
        public string? Availability { get; set; }

        public Hotel? Hotel { get; set; }
    }
}
