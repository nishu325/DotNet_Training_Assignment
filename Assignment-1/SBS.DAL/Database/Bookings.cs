//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBS.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public int ServiceId { get; set; }
        public int MechanicId { get; set; }
        public int DealerId { get; set; }
        public System.DateTime BookingStartDate { get; set; }
        public System.DateTime BookingEndDate { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Dealers Dealers { get; set; }
        public virtual Mechanics Mechanics { get; set; }
        public virtual Services Services { get; set; }
        public virtual Vehicles Vehicles { get; set; }
    }
}
