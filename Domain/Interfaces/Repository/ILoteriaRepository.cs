using Domain.Documents;

namespace Domain.Interfaces.Repository
{
    public interface ILoteriaRepository<TDocument> where TDocument : LoteriaDocument
    {
        Task<IEnumerable<TDocument>> GetAsync();
        Task<TDocument> GetLastAsync();

    }
}
