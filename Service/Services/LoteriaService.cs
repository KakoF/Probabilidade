using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Service.Services
{
    public class LoteriaService<T> : ILoteriaService<T> where T : LoteriaDocument
    {
        private readonly ILoteriaRepositoryFactory<T, ILoteriaRepository<T>> _repositoryFactory;

        public LoteriaService(ILoteriaRepositoryFactory<T, ILoteriaRepository<T>> repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<IEnumerable<T>> GetAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.FactoryRepository(loteria);
            return (IEnumerable<T>)await repository.GetAsync();
        }

        public async Task<T> GetLastAsync(eLoteria loteria)
        {
            var repository = _repositoryFactory.FactoryRepository(loteria);
            return (T)await repository.GetLastAsync();
        }
    }
}
