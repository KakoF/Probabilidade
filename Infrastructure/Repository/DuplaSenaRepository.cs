using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class DuplaSenaRepository : LoteriaRepository<DuplaSenaDocument>, ILoteriaRepository<DuplaSenaDocument>, IDuplaSenaRepository
    {
        public DuplaSenaRepository(IMongoRepository<DuplaSenaDocument> repository) : base(repository)
        {
        }
    }
}
