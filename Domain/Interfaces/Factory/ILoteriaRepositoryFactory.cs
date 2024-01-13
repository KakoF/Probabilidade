using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;

namespace Domain.Interfaces.Factory
{
    public interface ILoteriaRepositoryFactory<out T, out TInterface> where T : LoteriaDocument where TInterface : ILoteriaRepository<T>
    {
        TInterface FactoryRepository(eLoteria loteria);
    }

}
