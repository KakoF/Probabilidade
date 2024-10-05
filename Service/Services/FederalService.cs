using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class FederalService : SorteioService<FederalModel, FederalDocument> , IFederalService
    {
        protected override int PadLeftZeros => 6;
        public FederalService(IFederalRepository repository) : base(repository)
        {
        }
    }
}
