using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class DiaDeSorteRepository : LoteriaRepository<DiaDeSorteDocument>, IDiaDeSorteRepository
    {
        public DiaDeSorteRepository(IMongoRepository<DiaDeSorteDocument> repository) : base(repository)
        {
        }
    }
}
