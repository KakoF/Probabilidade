using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Domain.Records;
using System.Collections.Generic;

namespace Service.Services
{
    public class LoteriaModelService<T, O> : ILoteriaModelService<O> where T : LoteriaDocument where O : LoteriaAbstract
    {
        private readonly ILoteriaServiceFactory<O, ILoteriaService<O>> _serviceFactory;
        private readonly ILoteriasExecuteCommand<O> _servicesCommand;

        public LoteriaModelService(ILoteriaServiceFactory<O, ILoteriaService<O>> serviceFactory, ILoteriasExecuteCommand<O> servicesCommand)
        {
            _serviceFactory = serviceFactory;
            _servicesCommand = servicesCommand;
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

        public async Task<ProbabilidadeExperimental> GerarEstivaAsync(eLoteria loteria)
        {
            var list = await GetAsync(loteria);
            return new ProbabilidadeExperimental(list);
        }
      
        public async Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, int numero)
        {
            var service = _serviceFactory.FactoryService(loteria);
            var list = await service.FilterByNumeroAsync(numero);
            return new LinhaDoTempo(numero, list);
        }

        public async Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(int numero)
        {
            var list = new List<LinhaDoTempo>();
            await foreach (var item in _servicesCommand.Execute(numero))
            {
                list.Add(new LinhaDoTempo(numero, item));
            }
            return list;
        }

    }
}
