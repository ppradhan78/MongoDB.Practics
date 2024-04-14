using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.Core
{

    public class RegionCore : BaseCore<Region>, IRegionCore
    {
        public RegionCore(IRegionRepository repository) : base(repository)
        {
        }
    }
}
