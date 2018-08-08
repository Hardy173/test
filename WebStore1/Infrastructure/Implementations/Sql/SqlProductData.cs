using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore1.DAL.Context;
using WebStore1.Domain.Model;
using WebStore1.Infrastructure.Interfaces;
using WebStore1.Models;

namespace WebStore1.Infrastructure.Implementations.Sql
{
    public class SqlProductData: IProductData
    {
        private readonly WebStore1Context _context;
        public SqlProductData(WebStore1Context context)
        {
            _context = context;
        }
        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }
        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }
        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.AsQueryable();
            if (filter.BrandId.HasValue)

                query = query.Where(c => c.BrandId.HasValue &&

                c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.SectionId.HasValue)
                query = query.Where(c => c.SectionId.Equals(filter.SectionId.Value));
            return query.ToList();
        }
    }
}
