using ElbrusAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ElbrusAPI.Database
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {
            
        }

        public DbSet<WorkerModel> Worker { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
