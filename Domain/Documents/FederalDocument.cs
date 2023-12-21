using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("Federal")]
    [BsonIgnoreExtraElements]
    public class FederalDocument : LoteriaDocument
    {
    }
}
