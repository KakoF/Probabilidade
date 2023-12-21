using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("MegaSena")]
    [BsonIgnoreExtraElements]
    public class MegaSenaDocument : LoteriaDocument
    {
    }
}
