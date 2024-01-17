using Domain.Documents;
using Domain.Models.Abstracts;


namespace Domain.Interfaces.Services
{
    public interface ILoteriaService<out T> where T : LoteriaAbstract
    {
        Task<IEnumerable<LoteriaAbstract>> GetAsync();
        Task<LoteriaAbstract> GetLastAsync();

    }
}