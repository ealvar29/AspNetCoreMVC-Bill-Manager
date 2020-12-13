using BillManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BillManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
    
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Bill> Bills { get; set; }

    }
}