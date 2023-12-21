using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoManiaRepository : LoteriaRepository<LotoManiaDocument>, ILotoManiaRepository<LotoManiaDocument>
    {
        public LotoManiaRepository(IMongoRepository<LotoManiaDocument> repository) : base(repository)
        {
        }
    }
}
