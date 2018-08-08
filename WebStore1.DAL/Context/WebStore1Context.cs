using Microsoft.EntityFrameworkCore;
using WebStore1.Domain.Model;
using WebStore1.Models;

namespace WebStore1.DAL.Context
{
    public class WebStore1Context: DbContext
    {
        public WebStore1Context(DbContextOptions options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
