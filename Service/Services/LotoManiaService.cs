using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class LotoManiaService : LoteriaService<LotoManiaModel, LotoManiaDocument>, ILotoManiaService
    {
        public LotoManiaService(ILotoManiaRepository repository) : base(repository)
        {
        }
    }
}
