using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("TimeMania")]
    [BsonIgnoreExtraElements]
    public class TimeManiaDocument : LoteriaDocument
    {
    }
}
