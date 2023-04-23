using MongoDB.Practics.Data.BusinessObjects.Base;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.Data.BusinessObjects
{
    public class SampleQuizRepository : BaseRepository<SampleQuiz>, ISampleQuizRepository
    {
        public SampleQuizRepository(IDatabaseContext context) : base(context)
        {
        }
    }
}
