namespace Fliper.Data
{
    using Fliper.Models;
    using Microsoft.EntityFrameworkCore;
    using Fliper.Models;

    namespace ProClientHub.Data
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Project> Projects { get; set; }
            public DbSet<Client> Clients { get; set; }
            public DbSet<ContactForm> ContactForms { get; set; }
            public DbSet<Subscription> Subscriptions { get; set; }
        }
    }

}
