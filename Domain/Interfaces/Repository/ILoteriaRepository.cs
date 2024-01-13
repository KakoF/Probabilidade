using Domain.Documents;

namespace Domain.Interfaces.Repository
{
    public interface ILoteriaRepository<T> where T : LoteriaDocument
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetLastAsync();

    }
}
