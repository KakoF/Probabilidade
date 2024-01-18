using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Domain.Records;

namespace Service.Services
{
    public class LoteriaModelService<T, O> : ILoteriaModelService<O> where T : LoteriaDocument where O : LoteriaAbstract
    {
        private readonly ILoteriaServiceFactory<O, ILoteriaService<O>> _serviceFactory;

        public LoteriaModelService(ILoteriaServiceFactory<O, ILoteriaService<O>> serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        public async Task<Estimativa> GerarEstivaAsync(eLoteria loteria)
        {
            var list = await GetAsync(loteria);
            return new Estimativa(list);


        }

        public async Task<IEnumerable<LoteriaAbstract>> GetAsync(eLoteria loteria)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return await service.GetAsync();
        }

        public async Task<LoteriaAbstract> GetLastAsync(eLoteria loteria)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return await service.GetLastAsync();
        }
    }
}
