using Domain.Documents.BaseDocument;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : Document
    {
        Task<IEnumerable<TDocument>> FindAllAsync();

        Task<IEnumerable<TDocument>> FindAllAsync(Expression<Func<TDocument, bool>> filterExpression, SortDefinition<TDocument> sorterExpression = null, int? limit = 1);


		Task<IEnumerable<TDocument>> FilterByAsync(Expression<Func<TDocument, bool>> filterExpression);

        Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression,  SortDefinition<TDocument> sorterExpression = null);

        Task<TDocument> FindByIdAsync(string id);

        Task InsertOneAsync(TDocument document);

        Task InsertManyAsync(ICollection<TDocument> documents);

        Task ReplaceOneAsync(TDocument document);

        Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression);

        Task DeleteByIdAsync(string id);
        Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression);
    }
}
