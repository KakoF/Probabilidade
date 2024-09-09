using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;
using Domain.Records;
using Domain.Records.Requests;

namespace Domain.Interfaces.Services
{
    public interface ISorteioModelService<out T> where T : SorteioAbstract
    {
        Task<IEnumerable<SorteioAbstract>> GetAsync(eLoteria loteria);
        Task<IEnumerable<SorteioAbstract>> GetLastAsync(eLoteria loteria, int? ultimos = 1);
        Task<ProbabilidadeCalculada> GerarEstivaAsync(eLoteria loteria);
        Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, LinhaTempoRequest request);
        Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(LinhaTempoRequest request);
    }
}
