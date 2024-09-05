using Domain.Documents;
using Domain.Models.Abstracts;


namespace Domain.Interfaces.Services
{
    public interface ISorteioService<out T> where T : SorteioAbstract
    {
        Task<IEnumerable<SorteioAbstract>> GetAsync();
        Task<IEnumerable<SorteioAbstract>> GetLastAsync(int? ultimos = 1);
        Task<IEnumerable<SorteioAbstract>> FilterByNumeroAsync(int numero);

    }
}