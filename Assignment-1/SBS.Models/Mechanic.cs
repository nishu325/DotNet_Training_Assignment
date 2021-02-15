using System.ComponentModel.DataAnnotations;

namespace SBS.Models
{
    public class Mechanic
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please specify the Mechanic name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please specify the Mechanic code.")]
        public string Code { get; set; }       
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Please specify the email of Mechanic.")]
        public string Email { get; set; }
        
    }
}
