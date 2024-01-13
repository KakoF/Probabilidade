using Domain.Documents;
using Domain.Interfaces.Repository;
using MongoDB.Driver;

namespace Infrastructure.Repository
{
    public abstract class LoteriaRepository<T> : ILoteriaRepository<T> where T : LoteriaDocument
    {
        private IMongoRepository<T> _repository;

        public LoteriaRepository(IMongoRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual async Task<IEnumerable<T>> GetAsync()
        {
            return await _repository.FindAllAsync();
        }

        public virtual async Task<T> GetLastAsync()
        {
            return await _repository.FindOneAsync(filterExpression: x => x.Id.ToString() != null, sorterExpression: Builders<T>.Sort.Descending(c => c.Concurso));
        }
    }
}
