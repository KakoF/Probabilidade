using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class TimeManiaRepository : LoteriaRepository<TimeManiaDocument>, ILoteriaRepository<TimeManiaDocument>, ITimeManiaRepository
    {
        public TimeManiaRepository(IMongoRepository<TimeManiaDocument> repository) : base(repository)
        {
        }
    }
}
