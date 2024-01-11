using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;

namespace Service.Services
{
    public class LoteriaService : ILoteriaService
    {
        private readonly ILoteriaRepositoryFactory<LoteriaDocument> _repositoryFactory;

        public LoteriaService(ILoteriaRepositoryFactory<LoteriaDocument> repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IEnumerable<LoteriaDocument>> GetAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.CreateCommand(loteria);
            return await repository.GetAsync();
        }
        public async Task<LoteriaDocument> GetLastAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.CreateCommand(loteria);
            return await repository.GetLastAsync();
        }
    }
}
