using System.ComponentModel.DataAnnotations;

namespace BIGBANG_Assesment.Models
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? Password { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
