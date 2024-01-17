using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;

namespace Domain.Interfaces.Services
{
    public interface ILoteriaModelService<T> where T : LoteriaAbstract
    {
        Task<IEnumerable<T>> GetAsync(eLoteria loteria);
        Task<T> GetLastAsync(eLoteria loteria);
    }
}
