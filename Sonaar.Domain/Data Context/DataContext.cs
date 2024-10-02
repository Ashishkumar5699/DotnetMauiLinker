using Sonaar.Domain.Approvals;
using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;
using Sonaar.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using Sonaar.Domain.Entities.Authentication;

namespace Sonaar.Domain.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Gold> GoldStock { get; set; }

        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }

        public DbSet<ContactDetails> ContactDetails { get; set; }

        //public DbSet<Quotation> Quotation { get; set; }

        public DbSet<Quotation> Quotations { get; set; }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quotation>()
            .HasMany(q => q.ProductList)
            .WithOne(p => p.Quotation)
            .HasForeignKey(p => p.QuotationId);

        }
    }
}

