using Domain.Enums;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Domain.Interfaces.Factory
{
    public interface ISorteioServiceFactory<out T, out TInterface> where T : SorteioAbstract where TInterface : ISorteioService<T>
    {
        TInterface FactoryService(eLoteria loteria);
    }
}
