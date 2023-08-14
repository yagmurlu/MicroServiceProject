using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Infrastructure.Persistance.Context
{
    public class OrderContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=CasgemOrderDb;user=sa;password=123456789Aleyna");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ordering> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }

}
