using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class DuplaSenaRepository : LoteriaRepository<DuplaSenaDocument>, IDuplaSenaRepository<DuplaSenaDocument>
    {
        public DuplaSenaRepository(IMongoRepository<DuplaSenaDocument> repository) : base(repository)
        {
        }
    }
}
