using Domain.Models.Abstracts;

namespace Domain.Interfaces.Services
{
    public interface ILoteriasExecuteCommand<T> where T : SorteioAbstract
    {
		IAsyncEnumerable<IEnumerable<IEnumerable<T>>> Execute(IEnumerable<int> numeros, DateTime dataInicio);

	}
}
