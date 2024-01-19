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

        public async Task<Estimativa> GerarEstivaAsync(eLoteria loteria)
        {
            var list = await GetAsync(loteria);
            return new Estimativa(list);
        }

        public async Task<Estimativa> GerarEstivaAsync(eLoteria loteria, int numero)
        {
            var service = _serviceFactory.FactoryService(loteria);
            var list = await service.FilterByNumeroAsync(numero);
            return new Estimativa(list);
        }


        public async Task<LinhaTempo> LinhaTempoAsync(eLoteria loteria, int numero)
        {
            var service = _serviceFactory.FactoryService(loteria);
            var list = await service.FilterByNumeroAsync(numero);
            return new LinhaTempo(numero, list);
        }

        public async Task<IEnumerable<LinhaTempo>> LinhaTempoAsync(int numero)
        {
            var list = new List<LinhaTempo>();
            await foreach (var item in _servicesCommand.Execute(numero))
            {
                list.Add(new LinhaTempo(numero, item));
            }
            return list;
        }

        public async Task<IEnumerable<Analise>> AnaliseJogoAsync(eLoteria loteria, IEnumerable<int> numeros)
        {
            var list = new List<Analise>();
            foreach (var numero in numeros)
            {
                var sorteios = await GetAsync(loteria);
                var estimativa = await GerarEstivaAsync(loteria, numero);
                var linhaTempo = await LinhaTempoAsync(loteria, numero);
                list.Add(new Analise(numero, sorteios.Count(), estimativa.TotalSorteios, linhaTempo, ((decimal)estimativa.TotalSorteios / (decimal)sorteios.Count()) * 100));
            }
            return list;
        }
    }
}
