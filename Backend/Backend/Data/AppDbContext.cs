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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Computers", ParentId = null },
                    new Category { Id = 2, Name = "Desktops", ParentId = 1 },
                    new Category { Id = 3, Name = "Laptops", ParentId = 1 },
                    new Category { Id = 4, Name = "Mini PCs", ParentId = 1 },
                    new Category { Id = 5, Name = "All-in-One PCs", ParentId = 1 },
                    new Category { Id = 6, Name = "Computer Components", ParentId = 1 },
                    new Category { Id = 7, Name = "Processors (CPU)", ParentId = 6 },
                    new Category { Id = 8, Name = "Graphics Cards (GPU)", ParentId = 6 },
                    new Category { Id = 9, Name = "Motherboards", ParentId = 6 },
                    new Category { Id = 10, Name = "Memory (RAM)", ParentId = 6 },
                    new Category { Id = 11, Name = "Solid State Drives (SSD)", ParentId = 6 },
                    new Category { Id = 12, Name = "Hard Drives (HDD)", ParentId = 6 },
                    new Category { Id = 13, Name = "Power Supplies", ParentId = 6 },
                    new Category { Id = 14, Name = "Computer Cases", ParentId = 6 },
                    new Category { Id = 15, Name = "Cooling Systems", ParentId = 6 },
                    new Category { Id = 16, Name = "Peripherals", ParentId = 1 },
                    new Category { Id = 17, Name = "Keyboards", ParentId = 16 },
                    new Category { Id = 18, Name = "Mice", ParentId = 16 },
                    new Category { Id = 19, Name = "Mouse Pads", ParentId = 16 },
                    new Category { Id = 20, Name = "Monitors", ParentId = 16 },
                    new Category { Id = 21, Name = "Webcams", ParentId = 16 },
                    new Category { Id = 22, Name = "Headsets", ParentId = 16 },
                    new Category { Id = 23, Name = "Speakers", ParentId = 16 },
                    new Category { Id = 24, Name = "Microphones", ParentId = 16 },
                    new Category { Id = 25, Name = "Networking", ParentId = 1 },
                    new Category { Id = 26, Name = "Routers", ParentId = 25 },
                    new Category { Id = 27, Name = "Network Switches", ParentId = 25 },
                    new Category { Id = 28, Name = "Network Adapters", ParentId = 25 },
                    new Category { Id = 29, Name = "Modems", ParentId = 25 },
                    new Category { Id = 30, Name = "Storage Devices", ParentId = 1 },
                    new Category { Id = 31, Name = "External Hard Drives", ParentId = 30 },
                    new Category { Id = 32, Name = "External SSDs", ParentId = 30 },
                    new Category { Id = 33, Name = "USB Flash Drives", ParentId = 30 },
                    new Category { Id = 34, Name = "Memory Cards", ParentId = 30 }
                );
        }

    }
}
