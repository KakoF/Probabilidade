using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class FederalRepository : SorteioRepository<FederalDocument>, IFederalRepository
    {
        public FederalRepository(IMongoRepository<FederalDocument> repository) : base(repository)
        {
        }
    }
}
