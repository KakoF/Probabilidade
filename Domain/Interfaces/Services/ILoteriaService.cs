using Domain.Documents;
using Domain.Enums;

namespace Domain.Interfaces.Services
{
    public interface ILoteriaService<T> where T : LoteriaDocument
    {
        Task<IEnumerable<T>> GetAsync(eLoteria loteria);
        Task<T> GetLastAsync(eLoteria loteria);
    }
}
