using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Domain.Records;
using Domain.Records.Requests;

namespace Service.Services
{
    public class SorteioModelService<T, O> : ISorteioModelService<O> where T : SorteioDocument where O : SorteioAbstract
    {
        private readonly ISorteioServiceFactory<O, ISorteioService<O>> _serviceFactory;
        private readonly ILoteriasExecuteCommand<O> _servicesCommand;

        public SorteioModelService(ISorteioServiceFactory<O, ISorteioService<O>> serviceFactory, ILoteriasExecuteCommand<O> servicesCommand)
        {
            _serviceFactory = serviceFactory;
            _servicesCommand = servicesCommand;
        }

        public async Task<IEnumerable<SorteioAbstract>> GetAsync(eLoteria loteria)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return await service.GetAsync();
        }

        public async Task<IEnumerable<SorteioAbstract>> GetLastAsync(eLoteria loteria, int? ultimos = 1)
        {
            var service = _serviceFactory.FactoryService(loteria);
            return await service.GetLastAsync(ultimos);
        }

        public async Task<ProbabilidadeCalculada> GerarEstivaAsync(eLoteria loteria)
        {
            var list = await GetAsync(loteria);
            return new ProbabilidadeCalculada(list);
        }
      
        public async Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, LinhaTempoRequest request)
        {
            var ordered = request.Numeros.Distinct().OrderBy(numeros => numeros).ToList();

			var service = _serviceFactory.FactoryService(loteria);
            var list = await service.FilterByNumeroAsync(ordered, request.DataInicio);
            return new LinhaDoTempo(ordered, list);
        }

        public async Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(LinhaTempoRequest request)
        {
			var ordered = request.Numeros.Distinct().OrderBy(numeros => numeros).ToList();

			var list = new List<LinhaDoTempo>();
            await foreach (var item in _servicesCommand.Execute(ordered, request.DataInicio))
                list.Add(new LinhaDoTempo(ordered, item));
            
            return list;
        }

    }
}
