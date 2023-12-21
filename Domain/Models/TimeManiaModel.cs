using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class TimeManiaModel : LoteriaAbstract
    {
        protected override string Nome => "Time Mania";
        public TimeManiaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        {
        }
    }
}
