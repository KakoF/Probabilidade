using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public abstract class SorteioService<T, O> : ISorteioService<T> where T : SorteioAbstract where O : SorteioDocument
    {
        protected virtual int PadLeftZeros { get; } = 2;

        private readonly ISorteioRepository<O> _repository;
        public SorteioService(ISorteioRepository<O> repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<SorteioAbstract>> GetAsync()
        {
            var document = await _repository.GetAsync();
            var models = document.Select(x => x.ToModel());
            return models;
        }

        public async Task<IEnumerable<SorteioAbstract>> GetLastAsync(int? ultimos = 1)
        {
            var document = await _repository.GetLastAsync(ultimos);
			var models = document.Select(x => x.ToModel());
			return models;
		}

        public async Task<IEnumerable<IEnumerable<SorteioAbstract>>> FilterByNumeroAsync(IEnumerable<int> numeros, DateTime dataInicio)
        {
            var result = new List<IEnumerable<SorteioAbstract>>();

            foreach (var numero in numeros)
            {
				var document = await _repository.FilterByAsync(x => x.Dezenas.Any(x => x.Equals(numero.ToString().PadLeft(PadLeftZeros, '0'))));
                document = document.Where(x => Convert.ToDateTime(x.Data).Year >= dataInicio.Year);
				result.Add(document.Select(x => x.ToModel()));
			}
            return result;
        }
    }

}
