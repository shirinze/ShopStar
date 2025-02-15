using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShopStar.Discount.Entities;
using System.Data;

namespace ShopStar.Discount.Context
{
    public class DapperContext:DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-39U8THB\\SQLEXPRESS; initial Catalog=ShopStarDiscountDb; integrated Security=true;");
        }
        public DbSet<Coupon> Coupons { get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
