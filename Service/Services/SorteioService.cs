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

        public async Task<SorteioAbstract> GetLastAsync()
        {
            var document = await _repository.GetLastAsync();
            return document.ToModel();
        }

        public async Task<IEnumerable<SorteioAbstract>> FilterByNumeroAsync(int numero)
        {
            var document = await _repository.FilterByAsync(x => x.Dezenas.Any(x => x.Equals(numero.ToString().PadLeft(PadLeftZeros, '0'))));
            var models = document.Select(x => x.ToModel());
            return models;
        }
    }

}
