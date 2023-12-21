using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class LotoFacilModel : LoteriaAbstract
    {
        protected override string Nome => "Loto Fácil";
        public LotoFacilModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
