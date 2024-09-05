using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class MaisMilionariaRepository : SorteioRepository<MaisMilionariaDocument>, IMaisMilionariaRepository
    {
        public MaisMilionariaRepository(IMongoRepository<MaisMilionariaDocument> repository) : base(repository)
        {
        }
    }
}
