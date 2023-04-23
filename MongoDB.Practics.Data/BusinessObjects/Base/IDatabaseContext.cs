using MongoDB.Driver;
namespace MongoDB.Practics.Data.BusinessObjects.Base
{
    public interface IDatabaseContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
