using Domain.Documents.BaseDocument;
using Domain.Models;
using Domain.Models.Abstracts;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    [BsonCollection("DiadeSorte")]
    [BsonIgnoreExtraElements]
    public class DiaDeSorteDocument : LoteriaDocument
    {
        public DiaDeSorteDocument(string loteria, int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos, IEnumerable<Premiacao> premiacoes) : base(loteria, concurso, data, local, dezenasOrdemSorteio, dezenas, trevos, premiacoes)
        {
        }

        public override LoteriaAbstract ToModel()
        {
            return new DiaDeSorteModel(this);
        }
    }
}
