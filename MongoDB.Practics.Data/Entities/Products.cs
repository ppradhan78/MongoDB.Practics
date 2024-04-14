using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Products")]
    public  class Products : BaseEntity
    {
        public int ProductsID { get; set; }
        public string ProductsDescription { get; set; }
    }
}
