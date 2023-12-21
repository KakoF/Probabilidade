using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("LotoMania")]
    [BsonIgnoreExtraElements]
    public class LotoManiaDocument : LoteriaDocument
    {
    }
}
