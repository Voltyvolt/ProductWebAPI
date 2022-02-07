using Microsoft.EntityFrameworkCore;
using Webapp.Helper;

namespace Webapp
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder<DataContext> options) => options.UseSqlite(@"Data Source=D:\Pyt\Webapp\DbTest.db");


    }
}
