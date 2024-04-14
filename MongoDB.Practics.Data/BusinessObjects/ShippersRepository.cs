using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public class ShippersRepository : BaseRepository<Shippers>, IShippersRepository
    {
        public ShippersRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
