//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheExchange.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public class Venue
    {
        public Venue()
        {
            //this.Tickets = new HashSet<Ticket>();
            this.Services = new HashSet<Service>();
        }
    
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int VenueTypeId { get; set; }
        public Nullable<decimal> GuyFee { get; set; }
        public Nullable<decimal> GirlFee { get; set; }
        public Nullable<System.DateTime> Cutoff { get; set; }
        public Nullable<decimal> TotalComission { get; set; }
        public Nullable<decimal> LeadGuyComission { get; set; }
        public Nullable<decimal> LeadGirlComission { get; set; }
        public Nullable<decimal> RepGuyComission { get; set; }
        public Nullable<decimal> RepGirlComission { get; set; }
        public Nullable<decimal> HouseGuyComission { get; set; }
        public Nullable<decimal> HouseGirlComission { get; set; }
        public bool Active { get; set; }
        public System.DateTime AddedDate { get; set; }
    
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual VenueType VenueType { get; set; }
    }
}
