using Domain.Documents;
using Domain.Interfaces.Repository;
using MongoDB.Driver;

namespace Infrastructure.Repository
{
    public abstract class LoteriaRepository<TDocument> : ILoteriaRepository<TDocument> where TDocument : LoteriaDocument
    {
        private IMongoRepository<TDocument> _repository;

        public LoteriaRepository(IMongoRepository<TDocument> repository)
        {
            _repository = repository;
        }
        public virtual async Task<IEnumerable<TDocument>> GetAsync()
        {
            return await _repository.FindAllAsync();
        }

        public virtual async Task<TDocument> GetLastAsync()
        {
            return await _repository.FindOneAsync(sorterExpression: Builders<TDocument>.Sort.Descending(c => c.Data));
        }
    }
}
