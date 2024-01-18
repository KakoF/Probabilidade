using Domain.Documents;

namespace Domain.Models.Abstracts
{
    public abstract class LoteriaAbstract
    {
        public abstract Tuple<int, int> RangeNumeros { get; }
        public abstract string Nome { get; }
        public int Concurso { get; }
        public string Data { get; }
        public string Local { get; }
        public IEnumerable<string> DezenasOrdemSorteio { get; }
        public IEnumerable<string> Dezenas { get; }
        public IEnumerable<string> Trevos { get; }

        protected LoteriaAbstract(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos)
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
