using Backend.Models.Product;
using Microsoft.EntityFrameworkCore;

using ProductModel = Backend.Models.Product.Product;
using AttributeModel = Backend.Models.Product.Attribute;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AttributeModel> Attributes { get; set; }
        public DbSet<AttributeValue> AttributesValues { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<VariantAttribute> VariantAttributes { get; set; }

    }
}
