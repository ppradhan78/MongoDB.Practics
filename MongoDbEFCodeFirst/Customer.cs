using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbEFCodeFirst
{
    public class Customer
    {
        public ObjectId Id { get; set; }
        public String Name { get; set; }
        public String Order { get; set; }
    }
}
