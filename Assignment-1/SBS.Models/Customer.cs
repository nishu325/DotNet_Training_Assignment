using System.ComponentModel.DataAnnotations;
namespace SBS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your Address.")]
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Required(ErrorMessage ="Please enter your ZipCode.")]
        public string ZipCode { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your Password.")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please enter your mobile number.")]
        public string MobileNo { get; set; }
    }
}
