using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public class LoteriasExecuteCommand<T> : ILoteriasExecuteCommand<T> where T : LoteriaAbstract
    {
       
        private readonly ILoteriaServiceFactory<T, ILoteriaService<T>> _serviceFactory;

        public LoteriasExecuteCommand(ILoteriaServiceFactory<T, ILoteriaService<T>> serviceFactory)
        {

            _serviceFactory = serviceFactory;
        }

        /*public async IAsyncEnumerable<T> Execute(int numero)
        {
            var loterias = Enum.GetValues(typeof(eLoteria)).Cast<eLoteria>();
            foreach (var loteria in loterias)
            {
                var service = _serviceFactory.FactoryService(loteria);
                var teste = await service.FilterByNumeroAsync(numero);
                yield return await service.FilterByNumeroAsync(numero);
            }
        }*/

        public async IAsyncEnumerable<IEnumerable<T>> Execute(int numero)
        {
            var loterias = Enum.GetValues(typeof(eLoteria)).Cast<eLoteria>();
            foreach (var loteria in loterias)
            {
                var service = _serviceFactory.FactoryService(loteria);
                yield return (IEnumerable<T>)await service.FilterByNumeroAsync(numero);
            }
        }
    }
}
