using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Shippers")]
    public  class Shippers : BaseEntity
    {
        public int ShippersID { get; set; }
        public string ShippersDescription { get; set; }
    }
}
