using Domain.Documents;
using Domain.Documents.BaseDocument;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Infrastructure.Configs.MongoConfigs;

namespace Infrastructure.Repository.Factory
{
    public class LoteriaRepositoryFactory : ILoteriaRepositoryFactory
    {
        private readonly IMongoRepository<Document> _repository;
        private readonly MongoDbSettings _settings;
        public LoteriaRepositoryFactory(IMongoRepository<Document> repository, MongoDbSettings settings)
        {
            _repository = repository;
            _settings = settings;
        }
        public ILoteriaRepository<LoteriaDocument> Create(eLoteria loteria)
        {
            switch (loteria)
            {
                case eLoteria.DuplaSena:
                    return (ILoteriaRepository<LoteriaDocument>)new DuplaSenaRepository((IMongoRepository<DuplaSenaDocument>)_repository);
                case eLoteria.Federal:
                    return (ILoteriaRepository<LoteriaDocument>)new FederalRepository((IMongoRepository<FederalDocument>)_repository);
                case eLoteria.LotoFacil:
                    return (ILoteriaRepository<LoteriaDocument>)new LotoFacilRepository((IMongoRepository<LotoFacilDocument>)_repository);
                case eLoteria.LotoMania:
                    return (ILoteriaRepository<LoteriaDocument>)new LotoManiaRepository((IMongoRepository<LotoManiaDocument>)_repository);
                case eLoteria.MaisMilionaria:
                    return (ILoteriaRepository<LoteriaDocument>)new MaisMilionariaRepository((IMongoRepository<MaisMilionariaDocument>)_repository);
                case eLoteria.MegaSena:
                    return (ILoteriaRepository<LoteriaDocument>)new MegaSenaRepository((IMongoRepository<MegaSenaDocument>)_repository);
                case eLoteria.Quina:
                    return (ILoteriaRepository<LoteriaDocument>)new QuinaRepository((IMongoRepository<QuinaDocument>)_repository);
                case eLoteria.SuperSete:
                    return (ILoteriaRepository<LoteriaDocument>)new SuperSeteRepository((IMongoRepository<SuperSeteDocument>)_repository);
                case eLoteria.TimeMania:
                    return (ILoteriaRepository<LoteriaDocument>)new TimeManiaRepository((IMongoRepository<TimeManiaDocument>)_repository);
                default:
                    throw new InvalidOperationException("Tipo de loteria inválida");
            }
        }
    }
}
