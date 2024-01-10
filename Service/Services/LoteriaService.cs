using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;

namespace Service.Services
{
    public class LoteriaService : ILoteriaService
    {
        private readonly ILoteriaRepositoryFactory _repositoryFactory;

        public LoteriaService(ILoteriaRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IEnumerable<LoteriaDocument>> GetAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.Create(loteria);
            return await repository.GetAsync();
        }
        public async Task<LoteriaDocument> GetLastAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.Create(loteria);
            return await repository.GetLastAsync();
        }
    }
}
