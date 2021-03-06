﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheExchange.Domain.Concrete
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using TheExchange.Domain.Entities;

    public class TheExchangeDbContext : DbContext
    {
        public TheExchangeDbContext()
            : base("name=TheExchangeDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>()
                .HasMany(c=>c.Services).WithMany(v=>v.Venues)
                .Map(t=>t.MapLeftKey("VenueId")
                        .MapRightKey("ServiceId")
                        .ToTable("VenueServices"));
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        
        public virtual DbSet<VenueType> VenueTypes { get; set; }
    }
}
