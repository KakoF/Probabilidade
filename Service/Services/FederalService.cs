using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class FederalService : LoteriaService<FederalModel> , IFederalService
    {
        public FederalService(IFederalRepository repository) : base(repository)
        {
        }
    }
}
