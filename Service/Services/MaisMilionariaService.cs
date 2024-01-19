using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class MaisMilionariaService : LoteriaService<MaisMilionariaModel, MaisMilionariaDocument>, IMaisMilionariaService
    {
        public MaisMilionariaService(IMaisMilionariaRepository repository) : base(repository)
        {
        }
    }
}
