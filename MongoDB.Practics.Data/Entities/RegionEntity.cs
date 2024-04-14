using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Region")]
    public  class Region : BaseEntity
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
