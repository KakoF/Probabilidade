using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class FederalRepository : LoteriaRepository<FederalDocument>, IFederalRepository
    {
        public FederalRepository(IMongoRepository<FederalDocument> repository) : base(repository)
        {
        }
    }
}
