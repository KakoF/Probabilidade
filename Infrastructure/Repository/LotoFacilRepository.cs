using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoFacilRepository : LoteriaRepository<LotoFacilDocument>, ILoteriaRepository<LotoFacilDocument>, ILotoFacilRepository
    {
        public LotoFacilRepository(IMongoRepository<LotoFacilDocument> repository) : base(repository)
        {
        }
    }
}
