using FDMC.Models;
using Microsoft.EntityFrameworkCore;

namespace FDMC
{
    public class WebAppContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public WebAppContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
