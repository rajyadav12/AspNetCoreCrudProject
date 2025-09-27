using AspNetCoreCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCrud.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
    }
}
