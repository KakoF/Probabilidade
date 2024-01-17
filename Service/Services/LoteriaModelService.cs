using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public class LoteriaModelService<T, O> : ILoteriaModelService<O> where T : LoteriaDocument where O : LoteriaAbstract
    {
        private readonly ILoteriaServiceFactory<O, ILoteriaService<O>> _serviceFactory;

        public LoteriaModelService(ILoteriaServiceFactory<O, ILoteriaService<O>> serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        public async Task<IEnumerable<O>> GetAsync(eLoteria loteria)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return (IEnumerable<O>)await service.GetAsync();
        }

        public async Task<O> GetLastAsync(eLoteria loteria)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return (O)await service.GetLastAsync();
        }
    }
}
