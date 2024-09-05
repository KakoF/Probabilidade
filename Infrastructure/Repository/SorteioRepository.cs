using Domain.Documents;
using Domain.Interfaces.Repository;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public abstract class SorteioRepository<T> : ISorteioRepository<T> where T : SorteioDocument
    {
        private IMongoRepository<T> _repository;

        public SorteioRepository(IMongoRepository<T> repository)
        {
            _repository = repository;
        }

        public async virtual Task<IEnumerable<T>> GetAsync()
        {
            return await _repository.FindAllAsync();
        }

        public async virtual Task<T> GetLastAsync()
        {
            return await _repository.FindOneAsync(filterExpression: x => x.Id.ToString() != null, sorterExpression: Builders<T>.Sort.Descending(c => c.Concurso));
        }

        public async virtual Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> expresion)
        {
            return await _repository.FilterByAsync(filterExpression: expresion);
        }
    }
}
