using Domain.Documents;
using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class LotoManiaModel : LoteriaAbstract
    {
        protected override string Nome => "Loto Mania";
        public LotoManiaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }

        public LotoManiaModel(LoteriaDocument document) : base(document.Concurso, document.Data, document.Local, document.DezenasOrdemSorteio, document.Dezenas, document.Trevos)
        {
        }
    }
}
