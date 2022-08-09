using Microsoft.EntityFrameworkCore;
using RFQManagement.Models;

namespace RFQManagement.DbaseContext
{
    public class RFQDbContext : DbContext
    {
        public RFQDbContext(DbContextOptions<RFQDbContext> options) : base(options) { }
        public DbSet<Rfq> Rfq { get; set; }
        public DbSet<Supplier> SUPPLIER { get; set; }

    }
}
