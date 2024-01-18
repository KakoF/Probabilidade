using Domain.Documents;
using Domain.Interfaces.Repository;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public abstract class LoteriaRepository<T> : ILoteriaRepository<T> where T : LoteriaDocument
    {
        private IMongoRepository<T> _repository;

        public LoteriaRepository(IMongoRepository<T> repository)
        {
            _repository = repository;
        }

        public async virtual Task<IEnumerable<LoteriaDocument>> GetAsync()
        {
            return await _repository.FindAllAsync();
        }

        public async virtual Task<LoteriaDocument> GetLastAsync()
        {
            return await _repository.FindOneAsync(filterExpression: x => x.Id.ToString() != null, sorterExpression: Builders<T>.Sort.Descending(c => c.Concurso));
        }

        public async virtual Task<IEnumerable<LoteriaDocument>> FilterByNumeroAsync(int numero)
        {
            return await _repository.FilterByAsync(filterExpression: x => x.Dezenas.Any(x => x.Equals(numero.ToString().PadLeft(2, '0'))));
        }
    }
}
