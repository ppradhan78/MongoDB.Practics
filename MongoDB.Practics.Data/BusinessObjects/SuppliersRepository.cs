using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public class SuppliersRepository : BaseRepository<Suppliers>, ISuppliersRepository
    {
        public SuppliersRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
