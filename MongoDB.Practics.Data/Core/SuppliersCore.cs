using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class SuppliersCore : BaseCore<Suppliers>, ISuppliersCore
    {
        public SuppliersCore(ISuppliersRepository repository) : base(repository)
        {
        }
    }
}
