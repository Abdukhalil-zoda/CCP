using Microsoft.EntityFrameworkCore;

namespace CCP
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    }
}
