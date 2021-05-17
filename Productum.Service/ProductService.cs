using Productum.Core.Model;
using Productum.Persistence;
using System.Collections.Generic;

namespace Productum.Service
{
    public class ProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddProduct (Product product)
        {
            _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();

        }

        public void UpdateProduct(Product product)
        {
            _unitOfWork.Products.Update(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.Products.GetProducts();
        }

        public void DeleteProduct(Product product)
        {
            _unitOfWork.Products.Delete(product);
        }
    }
}
