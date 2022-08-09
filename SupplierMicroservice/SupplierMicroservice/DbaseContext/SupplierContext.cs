using Microsoft.EntityFrameworkCore;

namespace SupplierMicroservice.DbaseContext
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options) { }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supplier_Part> Supplier_Parts { get; set; }
    }
}
  