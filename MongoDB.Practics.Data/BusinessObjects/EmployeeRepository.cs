using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public class EmployeeRepository : BaseRepository<EmployeeEntity>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
