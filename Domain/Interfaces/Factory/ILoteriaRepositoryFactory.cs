using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;

namespace Domain.Interfaces.Factory
{
    public interface ILoteriaRepositoryFactory<T> where T : LoteriaDocument
    {
        ILoteriaRepository<T> CreateCommand(eLoteria loteria);
    }
}
