using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;
using Domain.Records;

namespace Domain.Interfaces.Services
{
    public interface ILoteriaModelService<out T> where T : LoteriaAbstract
    {
        Task<IEnumerable<LoteriaAbstract>> GetAsync(eLoteria loteria);
        Task<LoteriaAbstract> GetLastAsync(eLoteria loteria);
        Task<ProbabilidadeExperimental> GerarEstivaAsync(eLoteria loteria);
        Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, int numero);
        Task<IEnumerable<LinhaDoTempo>> LinhaTempoAsync(int numero);
    }
}
