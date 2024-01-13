using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class SuperSeteRepository : LoteriaRepository<SuperSeteDocument>, ILoteriaRepository<SuperSeteDocument>, ISuperSeteRepository
    {
        public SuperSeteRepository(IMongoRepository<SuperSeteDocument> repository) : base(repository)
        {
        }
    }
}
