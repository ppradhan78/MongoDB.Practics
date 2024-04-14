using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class ProductsCore : BaseCore<Products>, IProductsCore
    {
        public ProductsCore(IProductsRepository repository) : base(repository)
        {
        }
    }
}
