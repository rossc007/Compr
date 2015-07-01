using System.Data.Entity.Migrations;
using Compr.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Compr.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Compr.EntityFramework.ComprDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Compr";
        }

        protected override void Seed(Compr.EntityFramework.ComprDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
