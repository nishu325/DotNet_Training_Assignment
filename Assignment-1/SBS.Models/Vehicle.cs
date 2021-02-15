using System;
using System.ComponentModel.DataAnnotations;


namespace SBS.Models
{
    public class Vehicle
    {    
        public int Id { get; set; }
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Please enter LicencePlate of your vehicle.")]
        public string LicensePlate { get; set; }
        [Required(ErrorMessage ="Please specify Maker of your vehicle.")]
        public string Make { get; set; }
        [Required(ErrorMessage ="Please specify your vehicle model.")]
        public string Model { get; set; }
        [Required(ErrorMessage ="Please specify registration date of your vehicle.")]
        public DateTime RegistrationDate { get; set; }
        [Required(ErrorMessage ="Please specify what problem you facing in vehicle.")]
        public string Comments { get; set; }
        [Required(ErrorMessage ="Please specify chassis number of your vehicle.")]
        public string ChassisNo { get; set; }
        public int? ServiceId { get; set; }
        public int? DealerId { get; set; }
        public int? MechanicId { get; set; }
        public bool BookingStatus { get; set; }
        public DateTime? BookingConfirmDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DealerName { get; set; }
        public string MechanicName { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTime { get; set; }
        public decimal? ServicePrice { get; set; }
        public int CustomerId { get; set; }
        //public DateTime? StartDate { get; set; }
        //public DateTime? EndDate { get; set; }
    }
}
