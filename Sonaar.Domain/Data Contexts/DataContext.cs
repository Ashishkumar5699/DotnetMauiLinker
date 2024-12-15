using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;
using Microsoft.EntityFrameworkCore;
using Sonaar.Domain.Entities.Authentication;

namespace Sonaar.Domain.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }

        public DbSet<ContactDetails> ContactDetails { get; set; }

        public DbSet<Quotation> Quotations { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<Entities.PreSale.PreSaleEntity> PreSaleBills { get; set; }

        public DbSet<Entities.Global.FirmEntities> FirmEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quotation>()
            .HasMany(q => q.ProductList)
            .WithOne(p => p.Quotation)
            .HasForeignKey(p => p.QuotationId);

             modelBuilder.Entity<Entities.PreSale.PreSaleEntity>()
            .HasMany(q => q.ProductList)
            .WithOne(p => p.PreSaleEntity)
            .HasForeignKey(p => p.QuotationId);
        }
    }
}

