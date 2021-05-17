using Productum.Core.Model;
using System.Collections.Generic;

namespace Productum.Persistence.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(Product product);
        IEnumerable<Product> GetProducts();
        void Update(Product product);
    }
}