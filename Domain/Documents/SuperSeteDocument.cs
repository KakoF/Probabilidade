using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("SuperSete")]
    [BsonIgnoreExtraElements]
    public class SuperSeteDocument : LoteriaDocument
    {
    }
}
