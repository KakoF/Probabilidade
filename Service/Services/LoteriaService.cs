using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;

namespace Service.Services
{
    public class LoteriaService<T> : ILoteriaService<T> where T : LoteriaDocument
    {
        private readonly ILoteriaRepositoryFactory<T> _repositoryFactory;

        public LoteriaService(ILoteriaRepositoryFactory<T> repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IEnumerable<T>> GetAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.CreateCommand(loteria);
            return await repository.GetAsync();
        }

        public async Task<T> GetLastAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.CreateCommand(loteria);
            return await repository.GetLastAsync();
        }
    }
}
