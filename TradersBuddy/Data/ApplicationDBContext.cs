using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TradersBuddy.Model;


namespace WinFormEFDemo.Data
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Customer> customer { get; set; }
    }
}

