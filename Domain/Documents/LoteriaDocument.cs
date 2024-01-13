using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    public abstract class LoteriaDocument : Document
    {
        [BsonRequired()]
        [BsonElement("concurso")]
        public int Concurso { get; private set; }
        [BsonRequired()]
        [BsonElement("data")]
        public string Data { get; private set; }
        [BsonRequired()]
        [BsonElement("local")]
        public string Local { get; private set; }
        [BsonRequired()]
        [BsonElement("dezenasOrdemSorteio")]
        public IEnumerable<string> DezenasOrdemSorteio { get; private set; }
        [BsonRequired()]
        [BsonElement("dezenas")]
        public IEnumerable<string> Dezenas { get; private set; }
        [BsonRequired()]
        [BsonElement("trevos")]
        public IEnumerable<string> Trevos { get; private set; }

        public LoteriaDocument(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos)
        {
            Concurso = concurso;
            Data = data;
            Local = local;
            DezenasOrdemSorteio = dezenasOrdemSorteio;
            Dezenas = dezenas;
            Trevos = trevos;
        }
    }
}
