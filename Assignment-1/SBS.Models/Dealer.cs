using System.ComponentModel.DataAnnotations;


namespace SBS.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter Name of Dealer.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter Dealer Code.")]
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter Dealer mobile number.")]
        public string MobileNo { get; set; }
    }
}
