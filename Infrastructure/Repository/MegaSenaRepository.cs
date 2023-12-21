using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class MegaSenaRepository : LoteriaRepository<MegaSenaDocument>, IMegaSenaRepository<MegaSenaDocument>
    {
        public MegaSenaRepository(IMongoRepository<MegaSenaDocument> repository) : base(repository)
        {
        }
    }
}

