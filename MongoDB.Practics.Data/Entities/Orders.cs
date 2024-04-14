using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("Orders")]
    public  class Orders : BaseEntity
    {
        public int OrdersID { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public string OrderDate { get; set; }

        public string RequiredDate { get; set; }

        public string ShippedDate { get; set; }

        public string ShipVia { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }



    }
}
