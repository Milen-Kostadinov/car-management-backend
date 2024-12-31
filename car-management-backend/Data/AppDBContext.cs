using car_management_backend.Data.Entitities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace car_management_backend.Data
{
    public class AppDBContext : IdentityDbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Maintanance> Maintanances { get; set; }
        public DbSet<Garage> Garages { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
                
        }
    }
}
