
namespace DocumentManagement
{
    public static class DatabaseSeeder
    {
        internal static async Task SeedAsync(ApplicationDbContext context)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();


        }
    }
}
