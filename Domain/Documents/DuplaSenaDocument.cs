using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("DuplaSena")]
    [BsonIgnoreExtraElements]
    public class DuplaSenaDocument : LoteriaDocument
    {
    }
}
