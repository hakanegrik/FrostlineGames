using ECommerce.Entities;

namespace ECommerce.Repositories.Impls
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {

        }
    }
}
