using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;

namespace Domain.Interfaces.Factory
{
    public interface ILoteriaRepositoryFactory
    {
        ILoteriaRepository<LoteriaDocument> Create(eLoteria loteria);
    }
}
