using Microsoft.EntityFrameworkCore;

namespace dotnet_core_with_api_and_database.Models
{
    public class ItemContext:DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options):base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}
