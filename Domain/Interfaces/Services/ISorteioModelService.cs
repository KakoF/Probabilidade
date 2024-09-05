using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;
using Domain.Records;

namespace Domain.Interfaces.Services
{
    public interface ISorteioModelService<out T> where T : SorteioAbstract
    {
        Task<IEnumerable<SorteioAbstract>> GetAsync(eLoteria loteria);
        Task<SorteioAbstract> GetLastAsync(eLoteria loteria);
        Task<ProbabilidadeExperimental> GerarEstivaAsync(eLoteria loteria);
        Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, int numero);
        Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(int numero);
    }
}
