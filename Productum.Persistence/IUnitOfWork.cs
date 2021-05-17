using Productum.Persistence.Repositories;

namespace Productum.Persistence
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; set; }

        bool Complete();
    }
}