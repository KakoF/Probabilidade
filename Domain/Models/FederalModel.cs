using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class FederalModel : LoteriaAbstract
    {
        protected override string Nome => "Federal";
        public FederalModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
