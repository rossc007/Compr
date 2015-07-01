using Compr.EntityFramework;

namespace Compr.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly ComprDbContext _context;

        public InitialDataBuilder(ComprDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
