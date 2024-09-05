using Domain.Models.Abstracts;

namespace Domain.Interfaces.Services
{
    public interface ILoteriasExecuteCommand<T> where T : SorteioAbstract
    {
        IAsyncEnumerable<IEnumerable<T>> Execute(int numero);
    }
}
