using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("LotoFacil")]
    [BsonIgnoreExtraElements]
    public class LotoFacilDocument : LoteriaDocument
    {
    }
}
