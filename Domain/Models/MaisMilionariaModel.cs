using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class MaisMilionariaModel : LoteriaAbstract
    {
        protected override string Nome => "Mais Milionária";
        public MaisMilionariaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
