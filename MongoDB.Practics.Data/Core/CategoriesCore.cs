using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class CategoriesCore : BaseCore<Categories>, ICategoriesCore
    {
        public CategoriesCore(ICategoriesRepository repository) : base(repository)
        {
        }
    }
}
