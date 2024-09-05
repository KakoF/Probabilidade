using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;

namespace Domain.Interfaces.Factory
{
    public interface ISorteioRepositoryFactory<out T, out TInterface> where T : SorteioDocument where TInterface : ISorteioRepository<T>
    {
        TInterface FactoryRepository(eLoteria loteria);
    }

}
