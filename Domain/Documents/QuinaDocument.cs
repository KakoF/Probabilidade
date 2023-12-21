using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("Quina")]
    [BsonIgnoreExtraElements]
    public class QuinaDocument : LoteriaDocument
    {
    }
}
