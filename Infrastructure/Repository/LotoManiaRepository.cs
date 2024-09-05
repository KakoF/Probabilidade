using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoManiaRepository : SorteioRepository<LotoManiaDocument>, ILotoManiaRepository
    {
        public LotoManiaRepository(IMongoRepository<LotoManiaDocument> repository) : base(repository)
        {
        }
    }
}
