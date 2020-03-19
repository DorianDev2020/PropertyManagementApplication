using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Property_Management.Models;

namespace Property_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "LandLord",
                    NormalizedName = "LANDLORD"
                },
                new IdentityRole
                {
                    Name = "Contractor",
                    NormalizedName = "CONTRACTOR"
                },
                new IdentityRole
                {
                    Name = "Tennant",
                    NormalizedName = "TENNANT"
                }
                );
        }




    }
}
