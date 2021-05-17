using Productum.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Productum.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductumContext _context;
        public ProductRepository(ProductumContext context)
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }

        public void Delete(Product product)
        {
            _context.Remove(product);
        }
    }
}
