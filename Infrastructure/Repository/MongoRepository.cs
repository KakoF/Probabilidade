using Domain.Documents.BaseDocument;
using Domain.Interfaces.Repository;
using Infrastructure.Configs.MongoConfigs;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : Document
    {
        private readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(MongoDbSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }

        public virtual async Task<IEnumerable<TDocument>> FindAllAsync()
        {
            return await _collection.AsQueryable().ToListAsync();
        }

		public virtual async Task<IEnumerable<TDocument>> FindAllAsync(Expression<Func<TDocument, bool>> filterExpression, SortDefinition<TDocument> sorterExpression = null, int? limit = 1)
		{
			if (sorterExpression == null)
				return await _collection.Find(filterExpression).Limit(limit).ToListAsync();
			return await _collection.Find(filterExpression).Sort(sorterExpression).Limit(limit).ToListAsync();
		}

		public virtual async Task<IEnumerable<TDocument>> FilterByAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            return await _collection.Find(filterExpression).ToListAsync();
        }

        public virtual async Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression, SortDefinition<TDocument> sorterExpression = null)
        {
            if (sorterExpression == null)
                return await _collection.Find(filterExpression).FirstOrDefaultAsync();
            return await _collection.Find(filterExpression).Sort(sorterExpression).FirstOrDefaultAsync();
        }

	

		public virtual async Task<TDocument> FindByIdAsync(string id)
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
            return await _collection.Find(filter).SingleOrDefaultAsync();
        }


        public virtual async Task InsertOneAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
        }

        public virtual async Task InsertManyAsync(ICollection<TDocument> documents)
        {
            await _collection.InsertManyAsync(documents);
        }

        public virtual async Task ReplaceOneAsync(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.FindOneAndReplaceAsync(filter, document);
        }

        public async Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            await _collection.FindOneAndDeleteAsync(filterExpression);
        }

        public async Task DeleteByIdAsync(string id)
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
            await _collection.FindOneAndDeleteAsync(filter);
        }


        public async Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            await _collection.DeleteManyAsync(filterExpression);
        }


    }
}