using Microsoft.EntityFrameworkCore;
using WebAndroidApi.Data.Entities;

namespace WebAndroidApi.Data
{
    public class MyStoreContext : DbContext
    {
        public MyStoreContext(DbContextOptions<MyStoreContext> opts) : base(opts) {}

        public DbSet<CategoryEntity> Categories { get; set; }

    }
}
