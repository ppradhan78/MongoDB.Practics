using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class CustomersCore : BaseCore<Customers>, ICustomersCore
    {
        public CustomersCore(ICustomersRepository repository) : base(repository)
        {
        }
    }
}
