using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class TimeManiaRepository : SorteioRepository<TimeManiaDocument>, ITimeManiaRepository
    {
        public TimeManiaRepository(IMongoRepository<TimeManiaDocument> repository) : base(repository)
        {
        }
    }
}
