using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Infrastructure.Configs.MongoConfigs;

namespace Infrastructure.Repository.Factory
{
    public class LoteriaRepositoryFactory<T> : ILoteriaRepositoryFactory<T> where T : LoteriaDocument
    {
        private readonly MongoDbSettings _settings;
        public LoteriaRepositoryFactory(MongoDbSettings settings)
        {
            _settings = settings;
        }

        public ILoteriaRepository<T> CreateCommand(eLoteria loteria)
        {
            switch (loteria)
            {
                case eLoteria.DuplaSena:
                    return (ILoteriaRepository<T>)(new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings)) as IDuplaSenaRepository);
                case eLoteria.Federal:
                    return (ILoteriaRepository<T>)(new FederalRepository(new MongoRepository<FederalDocument>(_settings)) as IFederalRepository);
                case eLoteria.LotoFacil:
                    return (ILoteriaRepository<T>)(new LotoFacilRepository(new MongoRepository<LotoFacilDocument>(_settings)) as ILotoFacilRepository);
                case eLoteria.LotoMania:
                    return (ILoteriaRepository<T>)(new LotoManiaRepository(new MongoRepository<LotoManiaDocument>(_settings)) as ILotoManiaRepository);
                case eLoteria.MaisMilionaria:
                    return (ILoteriaRepository<T>)(new MaisMilionariaRepository(new MongoRepository<MaisMilionariaDocument>(_settings)) as IMaisMilionariaRepository);
                case eLoteria.MegaSena:
                    return (ILoteriaRepository<T>)(new MegaSenaRepository(new MongoRepository<MegaSenaDocument>(_settings)) as IMegaSenaRepository);
                case eLoteria.Quina:
                    return (ILoteriaRepository<T>)(new QuinaRepository(new MongoRepository<QuinaDocument>(_settings)) as IQuinaRepository);
                case eLoteria.SuperSete:
                    return (ILoteriaRepository<T>)(new SuperSeteRepository(new MongoRepository<SuperSeteDocument>(_settings)) as ISuperSeteRepository);
                case eLoteria.TimeMania:
                    return (ILoteriaRepository<T>)(new TimeManiaRepository(new MongoRepository<TimeManiaDocument>(_settings)) as ITimeManiaRepository);
                default:
                    throw new InvalidOperationException("Tipo de loteria inválida");
            }
        }
    }

}
