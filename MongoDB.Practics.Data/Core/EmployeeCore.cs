using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class EmployeeCore : BaseCore<EmployeeEntity>, IEmployeeCore
    {
        public EmployeeCore(IEmployeeRepository repository) : base(repository)
        {
        }
    }
}
