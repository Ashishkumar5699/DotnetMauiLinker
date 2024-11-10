using Sonaar.Domain.Approvals;
using Sonaar.Domain.Entities.Contacts;
using Sonaar.Domain.Entities.Product;
using Sonaar.Domain.Entities.Quotations;
using Sonaar.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using Sonaar.Domain.Entities.Authentication;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using Sonaar.Domain.Entities.PreSale;

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

        public DbSet<PreSaleEntity> PreSaleEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quotation>()
            .HasMany(q => q.ProductList)
            .WithOne(p => p.Quotation)
            .HasForeignKey(p => p.QuotationId);
        }
    }
}

