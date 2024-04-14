using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public interface IProductsRepository : IBaseRepository<Products>
    {
    }
}
