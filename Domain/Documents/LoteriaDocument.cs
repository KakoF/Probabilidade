using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    public class LoteriaDocument : Document
    {
        [BsonRequired()]
        [BsonElement("concurso")]
        public int Concurso { get; set; }
        [BsonRequired()]
        [BsonElement("data")]
        public string Data { get; set; }
        [BsonRequired()]
        [BsonElement("local")]
        public string Local { get; set; }
        [BsonRequired()]
        [BsonElement("dezenasOrdemSorteio")]
        public IEnumerable<string> DezenasOrdemSorteio { get; set; }
        [BsonRequired()]
        [BsonElement("dezenas")]
        public IEnumerable<string> Dezenas { get; set; }
        [BsonRequired()]
        [BsonElement("trevos")]
        public IEnumerable<string> Trevos { get; set; }
    }
}
