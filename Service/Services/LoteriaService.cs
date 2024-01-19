using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;

namespace Service.Services
{
    public abstract class LoteriaService<T, O> : ILoteriaService<T> where T : LoteriaAbstract where O : LoteriaDocument
    {
        protected virtual int PadLeftZeros { get; } = 2;

        private readonly ILoteriaRepository<O> _repository;
        public LoteriaService(ILoteriaRepository<O> repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<LoteriaAbstract>> GetAsync()
        {
            var document = await _repository.GetAsync();
            var models = document.Select(x => x.ToModel());
            return models;
        }

        public async Task<LoteriaAbstract> GetLastAsync()
        {
            var document = await _repository.GetLastAsync();
            return document.ToModel();
        }

        public async Task<IEnumerable<LoteriaAbstract>> FilterByNumeroAsync(int numero)
        {
            var document = await _repository.FilterByAsync(x => x.Dezenas.Any(x => x.Equals(numero.ToString().PadLeft(PadLeftZeros, '0'))));
            var models = document.Select(x => x.ToModel());
            return models;
        }
    }

}
