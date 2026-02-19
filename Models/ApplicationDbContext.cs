using Microsoft.EntityFrameworkCore;

namespace ApplicationFormApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationForm> ApplicationForms { get; set; }
    }
}
