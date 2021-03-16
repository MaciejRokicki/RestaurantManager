using Microsoft.EntityFrameworkCore;
using WebApplication.Api.Models;

namespace WebApplication.Dal
{
    public class RestaurantManagerContext : DbContext
    {
        public RestaurantManagerContext (DbContextOptions<RestaurantManagerContext> options)
            : base(options)
        {
        }
        
        public DbSet<Worker> Workers { get; set; }

    }
}
