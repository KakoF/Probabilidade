using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoManiaRepository : LoteriaRepository<LotoManiaDocument>, ILoteriaRepository<LotoManiaDocument>, ILotoManiaRepository
    {
        public LotoManiaRepository(IMongoRepository<LotoManiaDocument> repository) : base(repository)
        {
        }
    }
}
