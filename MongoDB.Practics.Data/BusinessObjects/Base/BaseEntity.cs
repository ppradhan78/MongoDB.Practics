using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
namespace MongoDB.Practics.Data.BusinessObjects.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } 

        private DateTime? createdDate;
        private DateTime? modifiedDate;
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate
        {
            get { return modifiedDate ?? DateTime.UtcNow; }
            set { modifiedDate = value; }
        }

       
    }
}
