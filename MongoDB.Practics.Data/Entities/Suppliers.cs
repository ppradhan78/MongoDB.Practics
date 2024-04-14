using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Suppliers")]
    public  class Suppliers : BaseEntity
    {
        public int SuppliersID { get; set; }
        public string SuppliersDescription { get; set; }
    }
}
