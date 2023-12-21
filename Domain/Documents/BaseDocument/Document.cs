using Domain.Interfaces.Repository;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents.BaseDocument
{
    public abstract class Document : IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }

    }
}
