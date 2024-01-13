using Domain.Documents;

namespace Domain.Interfaces.Repository
{
    public interface ILoteriaRepository<out T> where T : LoteriaDocument
    {
        Task<IEnumerable<LoteriaDocument>> GetAsync();
        Task<LoteriaDocument> GetLastAsync();

    }
}
