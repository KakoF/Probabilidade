using Domain.Documents;
using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class MegaSenaModel : LoteriaAbstract
    {
        protected override string Nome => "Mega Sena";
        public MegaSenaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
        public MegaSenaModel(LoteriaDocument document) : base(document.Concurso, document.Data, document.Local, document.DezenasOrdemSorteio, document.Dezenas, document.Trevos)
        {
        }
    }
}
