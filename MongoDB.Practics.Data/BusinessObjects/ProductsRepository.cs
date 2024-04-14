using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public class ProductsRepository : BaseRepository<Products>, IProductsRepository
    {
        public ProductsRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
