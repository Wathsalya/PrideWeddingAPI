using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PrideWeddingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Data
{
    public class WeddingDBContext:DbContext
    {
        public WeddingDBContext(DbContextOptions<WeddingDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
        }

        public DbSet<SaloonVendor> Saloons { get; set; }
        public DbSet<JwelVendor> Jwellers { get; set; }
        public DbSet<EntertainmentVendor> Entertainers { get; set; }
        public DbSet<PhotographyVendor> Photographers { get; set; }
        public DbSet<DecorationVendor> Decorators { get; set; }
        public DbSet<HotelVendor> Hotels { get; set; }   
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<AddingCart> CartItems { get; set; }
        public DbSet<ContactFormDetails> ContactUS { get; set; }





    }
}
