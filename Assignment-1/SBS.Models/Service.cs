using System.ComponentModel.DataAnnotations;
namespace SBS.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please set the service name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please set the code of this service.")]
        public string Code { get; set; }
        [Required(ErrorMessage ="Please specify the price of service.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage ="Please set the time for this service.")]
        public string Time { get; set; }
        [Required(ErrorMessage ="Please specify this service is available or not.")]
        public bool IsActive { get; set; }
        
    }
}
