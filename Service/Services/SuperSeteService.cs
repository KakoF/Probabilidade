using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class SuperSeteService : SorteioService<SuperSeteModel, SuperSeteDocument>, ISuperSeteService
    {
        public SuperSeteService(ISuperSeteRepository repository) : base(repository)
        {
        }
    }
}
