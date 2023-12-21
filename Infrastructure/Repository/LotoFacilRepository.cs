using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class LotoFacilRepository : LoteriaRepository<LotoFacilDocument>, ILotoFacilRepository<LotoFacilDocument>
    {
        public LotoFacilRepository(IMongoRepository<LotoFacilDocument> repository) : base(repository)
        {
        }
    }
}
