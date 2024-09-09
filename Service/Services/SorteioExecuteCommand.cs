using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public class SorteioExecuteCommand<T> : ILoteriasExecuteCommand<T> where T : SorteioAbstract
    {
       
        private readonly ISorteioServiceFactory<T, ISorteioService<T>> _serviceFactory;

        public SorteioExecuteCommand(ISorteioServiceFactory<T, ISorteioService<T>> serviceFactory)
        {

            _serviceFactory = serviceFactory;
        }
     
        public async IAsyncEnumerable<IEnumerable<IEnumerable<T>>> Execute(IEnumerable<int> numeros, DateTime dataInicio)
        {
            var loterias = Enum.GetValues(typeof(eLoteria)).Cast<eLoteria>();
            foreach (var loteria in loterias)
            {
                var service = _serviceFactory.FactoryService(loteria);
                yield return (IEnumerable<IEnumerable<T>>)await service.FilterByNumeroAsync(numeros, dataInicio);
            }
        }
    }
}
