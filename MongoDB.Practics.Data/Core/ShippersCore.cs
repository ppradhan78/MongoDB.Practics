using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class ShippersCore : BaseCore<Shippers>, IShippersCore
    {
        public ShippersCore(IShippersRepository repository) : base(repository)
        {
        }
    }
}
