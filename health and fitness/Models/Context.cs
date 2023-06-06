using Microsoft.EntityFrameworkCore;

namespace health_and_fitness.Models
{
    public class Context:DbContext
    {
        public Context (DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<TotalCaloriesBurned> tables { get; set; }   
    }
}
