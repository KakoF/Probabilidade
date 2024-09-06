using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;
using Domain.Records;

namespace Domain.Interfaces.Services
{
    public interface ISorteioModelService<out T> where T : SorteioAbstract
    {
        Task<IEnumerable<SorteioAbstract>> GetAsync(eLoteria loteria);
        Task<IEnumerable<SorteioAbstract>> GetLastAsync(eLoteria loteria, int? ultimos = 1);
        Task<ProbabilidadeCalculada> GerarEstivaAsync(eLoteria loteria);
        Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, int numero);
        Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(int numero);
    }
}
