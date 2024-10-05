using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class MegaSenaRepository : SorteioRepository<MegaSenaDocument>, IMegaSenaRepository
    {
        public MegaSenaRepository(IMongoRepository<MegaSenaDocument> repository) : base(repository)
        {
        }
    }
}

