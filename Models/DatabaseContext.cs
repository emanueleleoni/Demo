using Microsoft.EntityFrameworkCore;

namespace LK2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<ProductLanguage> ProductLanguages { get; set; }
        public DbSet<CategoryProductLanguage> CategoryProductLanguages { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ProductCategoryProductPosition> ProductCategoryProductPositions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Un prodotto appartiene ad una categoria, che invece può avere diverse prodotti
            modelBuilder.Entity<Product>()
                .HasOne<CategoryProduct>(p => p.CategoryProduct)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryProductID);

            // Un prodotto ha diverse traduzioni in lingua. Una lingua ha diverse traduzioni prodotti
            modelBuilder.Entity<ProductLanguage>()
                .HasKey(pl => new { pl.ProductID, pl.LanguageID });

            modelBuilder.Entity<ProductLanguage>()
                .HasOne(pl => pl.Product)
                .WithMany(p => p.ProductLanguages)
                .HasForeignKey(pl => pl.ProductID);

            modelBuilder.Entity<ProductLanguage>()
                .HasOne(pl => pl.Language)
                .WithMany(l => l.ProductLanguages)
                .HasForeignKey(pl => pl.LanguageID);

            // Una categoria prodotti ha diverse traduzioni in lingua. Una lingua ha diverse traduzioni categoria prodotti
            modelBuilder.Entity<CategoryProductLanguage>()
                .HasKey(cpl => new { cpl.CategoryProductID, cpl.LanguageID });

            modelBuilder.Entity<CategoryProductLanguage>()
                .HasOne(cpl => cpl.CategoryProduct)
                .WithMany(cp => cp.CategoryProductLanguages)
                .HasForeignKey(cpl => cpl.CategoryProductID);

            modelBuilder.Entity<CategoryProductLanguage>()
                .HasOne(cpl => cpl.Language)
                .WithMany(l => l.CategoryProductLanguages)
                .HasForeignKey(cpl => cpl.LanguageID);

            // Una categoria prodotti ha diversi prodotti in posizioni differenti
            modelBuilder.Entity<ProductCategoryProductPosition>()
                .HasKey(pcp => new { pcp.ProductID, pcp.CategoryProductID, pcp.Position });

            modelBuilder.Entity<ProductCategoryProductPosition>()
                .HasOne(pcp => pcp.CategoryProduct)
                .WithMany(cp => cp.ProductCategoryProductPositions)
                .HasForeignKey(pcp => pcp.CategoryProductID);

            modelBuilder.Entity<ProductCategoryProductPosition>()
                .HasOne(pcp => pcp.Product)
                .WithMany(p => p.ProductCategoryProductPositions)
                .HasForeignKey(pcp => pcp.ProductID);
        }
    }
}
