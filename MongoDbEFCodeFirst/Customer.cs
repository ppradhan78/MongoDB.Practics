using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbEFCodeFirst
{
    [Table("Customer")]
    public class Customer
    {
        public ObjectId Id { get; set; }
        public int CustomerId { get; set; }
        public String Name { get; set; }
        public String Order { get; set; }
    }
}
