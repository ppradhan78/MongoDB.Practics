﻿using MongoDB.Practics.Data.BusinessObjects.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.Practics.Data.Entities
{
    [Table("OrderDetails")]
    public  class OrderDetails : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}
