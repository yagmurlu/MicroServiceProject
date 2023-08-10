using CasgemMicroservice.Services.Discount.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CasgemMicroservice.Services.Discount.Context
{
    public class DapperContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemDiscountDb;User=sa;Password=123456789Aleyna");
        }
        public DbSet<DiscountCoupons> DiscountCouponses { get; set; }
    }
}
