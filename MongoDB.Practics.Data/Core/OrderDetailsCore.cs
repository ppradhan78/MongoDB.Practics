using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class OrderDetailsCore : BaseCore<OrderDetails>,IOrderDetailsCore
    {
        public OrderDetailsCore(IOrderDetailsRepository repository) : base(repository)
        {
        }
    }
}
