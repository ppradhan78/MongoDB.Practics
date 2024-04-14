using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class OrdersCore : BaseCore<Orders>, IOrdersCore
    {
        public OrdersCore(IOrdersRepository repository) : base(repository)
        {
        }
    }
}
