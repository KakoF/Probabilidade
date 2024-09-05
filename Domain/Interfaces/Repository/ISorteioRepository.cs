using Domain.Documents;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repository
{
    public interface ISorteioRepository<T> where T : SorteioDocument
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetLastAsync();
        Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> expresion);

    }
}
