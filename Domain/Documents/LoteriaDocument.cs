using Domain.Documents.BaseDocument;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Documents
{
    public abstract class LoteriaDocument : Document
    {
        [BsonRequired()]
        [BsonElement("loteria")]
        public string Loteria { get; private set; }
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

        [BsonRequired()]
        [BsonElement("premiacoes")]
        public IEnumerable<Premiacao> Premiacoes { get; private set; }



        public LoteriaDocument(string loteria, int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos, IEnumerable<Premiacao> premiacoes)
        {
            Loteria = loteria;
            Concurso = concurso;
            Data = data;
            Local = local;
            DezenasOrdemSorteio = dezenasOrdemSorteio;
            Dezenas = dezenas;
            Trevos = trevos;
            Premiacoes = premiacoes;
        }
    }


    public class Premiacao
    {
        [BsonRequired()]
        [BsonElement("descricao")]
        public string Descricao { get; set; }
        [BsonRequired()]
        [BsonElement("faixa")]
        public int Faixa { get; set; }
        [BsonRequired()]
        [BsonElement("ganhadores")]
        public int Ganhadores { get; set; }
        [BsonRequired()]
        [BsonElement("valorPremio")]
        public double ValorPremio { get; set; }
    }
}
