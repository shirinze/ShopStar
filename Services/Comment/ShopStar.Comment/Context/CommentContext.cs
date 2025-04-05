using Microsoft.EntityFrameworkCore;
using ShopStar.Comment.Entities;

namespace ShopStar.Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442; initial Catalog=ShopStarCommentDb; User=sa ;Password=123456aA*");
        }
        public DbSet<UserComment> UserComments { get; set; }
    }
}
