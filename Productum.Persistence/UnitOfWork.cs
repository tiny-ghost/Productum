using Productum.Persistence.Repositories;

namespace Productum.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductumContext _context;

        public IProductRepository Products { get; set; }

        public UnitOfWork(ProductumContext context)
        {
            _context = context;

            Products = new ProductRepository(context);
        }

        public bool Complete()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
