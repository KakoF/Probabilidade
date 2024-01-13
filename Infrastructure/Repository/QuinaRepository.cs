using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class QuinaRepository : LoteriaRepository<QuinaDocument>, IQuinaRepository
    {
        public QuinaRepository(IMongoRepository<QuinaDocument> repository) : base(repository)
        {
        }
    }
}
