using ECommerce.Entities;
using ECommerce.Repositories;

namespace ECommerce.Repositories.Impls
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {

        }
    }
}
