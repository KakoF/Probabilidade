using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class TimeManiaService: LoteriaService<TimeManiaModel>, ITimeManiaService
    {
        public TimeManiaService(ITimeManiaRepository repository) : base(repository)
        {
        }
    }
}
