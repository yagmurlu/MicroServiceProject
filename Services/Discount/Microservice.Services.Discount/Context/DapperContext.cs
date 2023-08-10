using Microservice.Services.Discount.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Microservice.Services.Discount.Context
{
    public class DapperContext : DbContext
    {
        //{
        //    private readonly IConfiguration _configuration;
        //    private readonly string _connectionstring;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemDsicountDb;User=sa;Password=123456789Aleyna");
        }
        public DbSet<DiscountCoupons> DiscountCouponses { get; set; }

        //public DapperContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    _connectionstring = _configuration.GetConnectionString("DefaultConnection");
        //}
        // public IDbConnection CreateConnection() => new SqlConnection(_connectionstring);
    }

}