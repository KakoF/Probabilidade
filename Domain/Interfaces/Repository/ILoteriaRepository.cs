using Domain.Documents;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface ILoteriaRepository<out T> where T : LoteriaDocument
    {
        Task<IEnumerable<LoteriaDocument>> GetAsync();
        Task<LoteriaDocument> GetLastAsync();
        Task<IEnumerable<LoteriaDocument>> FilterByNumeroAsync(int numero);

    }
}
