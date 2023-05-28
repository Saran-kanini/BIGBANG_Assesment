using System.ComponentModel.DataAnnotations;

namespace BIGBANG_Assesment.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_Id { get; set; }
        public string? Hotel_Name { get; set; }
        public string? Room_Number { get; set; }
        public int? UserId { get; set; }
        public Customer? Customer { get; set; }
    }
}
