using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("MaisMilionaria")]
    [BsonIgnoreExtraElements]
    public class MaisMilionariaDocument : LoteriaDocument
    {
        public MaisMilionariaDocument(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
