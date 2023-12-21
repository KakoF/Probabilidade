using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class SuperSeteModel : LoteriaAbstract
    {
        protected override string Nome => "Super Sete";
        public SuperSeteModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
