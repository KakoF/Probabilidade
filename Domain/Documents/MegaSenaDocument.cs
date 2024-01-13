using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("MegaSena")]
    [BsonIgnoreExtraElements]
    public class MegaSenaDocument : LoteriaDocument
    {
        public MegaSenaDocument(string loteria, int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(loteria, concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
