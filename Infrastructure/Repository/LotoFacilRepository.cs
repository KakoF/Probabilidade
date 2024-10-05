using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoFacilRepository : SorteioRepository<LotoFacilDocument>, ILotoFacilRepository
    {
        public LotoFacilRepository(IMongoRepository<LotoFacilDocument> repository) : base(repository)
        {
        }
    }
}
