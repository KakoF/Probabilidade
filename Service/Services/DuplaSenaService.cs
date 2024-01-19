using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class DuplaSenaService : LoteriaService<DuplaSenaModel, DuplaSenaDocument>, IDuplaSenaService
    {
        public DuplaSenaService(IDuplaSenaRepository repository) : base(repository)
        {
        }
    }
}
