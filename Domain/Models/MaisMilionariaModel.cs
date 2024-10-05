using Domain.Documents;
using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class MaisMilionariaModel : SorteioAbstract
    {
        public override string Nome => "Mais Milionária";
        public override Tuple<int, int> RangeNumeros => new Tuple<int, int>(1, 60);
        public MaisMilionariaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
        public MaisMilionariaModel(SorteioDocument document) : base(document.Concurso, document.Data, document.Local, document.DezenasOrdemSorteio, document.Dezenas, document.Trevos)
        {
        }
    }
}
