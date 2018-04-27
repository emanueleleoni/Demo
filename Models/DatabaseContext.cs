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
                .WithMany(cp => cp.GetCategoryProductLanguages)
                .HasForeignKey(cpl => cpl.CategoryProductID);

            modelBuilder.Entity<CategoryProductLanguage>()
                .HasOne(cpl => cpl.Language)
                .WithMany(l => l.CategoryProductLanguages)
                .HasForeignKey(cpl => cpl.LanguageID);
        }
    }
}
