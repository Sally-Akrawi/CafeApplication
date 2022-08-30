using DatabaseOperations.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseOperations.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<MilkType> MilkTypes { get; set; }
        public DbSet<FoodMenu> FoodTypes { get; set; }

        public DbSet<TeaMenu> TeaTypes { get; set; }
        public DbSet<SyrupMenu> SyrupTypes { get; set; }

        public DbSet<SweetenerMenu> SweetenerTypes { get; set; }

        public DbSet<ToppingMenu> ToppingTypes { get; set; }

        public DbSet<DrinkMenu> DrinkTypes { get; set; }
    }
}
