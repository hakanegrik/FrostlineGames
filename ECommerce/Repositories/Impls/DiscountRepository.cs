using ECommerce.Entities;

namespace ECommerce.Repositories.Impls
{
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        public DiscountRepository(Context context) : base(context)
        {

        }
    }
}
