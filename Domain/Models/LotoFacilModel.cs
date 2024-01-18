using Domain.Documents;
using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class LotoFacilModel : LoteriaAbstract
    {
        public override string Nome => "Loto Fácil";
        public override Tuple<int, int> RangeNumeros => new Tuple<int, int>(1, 60);
        public LotoFacilModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }

        public LotoFacilModel(LoteriaDocument document) : base(document.Concurso, document.Data, document.Local, document.DezenasOrdemSorteio, document.Dezenas, document.Trevos)
        {
        }
    }
}
