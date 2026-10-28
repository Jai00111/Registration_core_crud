using Microsoft.EntityFrameworkCore;

namespace corefirst_211026.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
        }
        public DbSet<Tbluser> Tblusers { get; set; }

    }
}
