using Domain.Documents;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class MaisMilionariaRepository : LoteriaRepository<MaisMilionariaDocument>, IMaisMilionariaRepository<MaisMilionariaDocument>
    {
        public MaisMilionariaRepository(IMongoRepository<MaisMilionariaDocument> repository) : base(repository)
        {
        }
    }
}
