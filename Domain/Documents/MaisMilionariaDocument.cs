using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("MaisMilionaria")]
    [BsonIgnoreExtraElements]
    public class MaisMilionariaDocument : LoteriaDocument
    {
    }
}
