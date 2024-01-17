using Domain.Documents;
using Domain.Enums;
using Domain.Models.Abstracts;

namespace Domain.Interfaces.Services
{
    public interface ILoteriaModelService<out T> where T : LoteriaAbstract
    {
        Task<IEnumerable<LoteriaAbstract>> GetAsync(eLoteria loteria);
        Task<LoteriaAbstract> GetLastAsync(eLoteria loteria);
    }
}
