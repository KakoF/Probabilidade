using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Domain.Interfaces
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }
    }
}