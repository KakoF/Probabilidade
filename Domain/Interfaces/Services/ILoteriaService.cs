using Domain.Documents;
using Domain.Enums;

namespace Domain.Interfaces.Services
{
    public interface ILoteriaService
    {
        Task<IEnumerable<LoteriaDocument>> GetAsync(eLoteria loteria);
        Task<LoteriaDocument> GetLastAsync(eLoteria loteria);
    }
}
