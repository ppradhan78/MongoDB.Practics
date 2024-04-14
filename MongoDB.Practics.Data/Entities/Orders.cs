using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Orders")]
    public  class Orders : BaseEntity
    {
        public int OrdersID { get; set; }
        public string OrdersDescription { get; set; }
    }
}
