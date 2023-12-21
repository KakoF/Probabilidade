namespace Domain.Models.Abstracts
{
    public abstract class LoteriaAbstract
    {
        protected abstract string Nome { get; }
        protected int Concurso { get; }
        protected string Data { get; }
        protected string Local { get; }
        protected IEnumerable<string> DezenasOrdemSorteio { get; }
        protected IEnumerable<string> Dezenas { get; }
        protected IEnumerable<string> Trevos { get; }

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
