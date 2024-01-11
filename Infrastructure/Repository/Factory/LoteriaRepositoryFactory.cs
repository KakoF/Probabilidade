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
                    var teste = new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings)).GetLastAsync() as ILoteriaRepository<T>;
                    var outrotste = teste.GetLastAsync();
                    return teste;
                case eLoteria.Federal:
                    return new FederalRepository(new MongoRepository<FederalDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.LotoFacil:
                    return new LotoFacilRepository(new MongoRepository<LotoFacilDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.LotoMania:
                    return new LotoManiaRepository(new MongoRepository<LotoManiaDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.MaisMilionaria:
                    return new MaisMilionariaRepository(new MongoRepository<MaisMilionariaDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.MegaSena:
                    return new MegaSenaRepository(new MongoRepository<MegaSenaDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.Quina:
                    return new QuinaRepository(new MongoRepository<QuinaDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.SuperSete:
                    return new SuperSeteRepository(new MongoRepository<SuperSeteDocument>(_settings)) as ILoteriaRepository<T>;
                case eLoteria.TimeMania:
                    return new TimeManiaRepository(new MongoRepository<TimeManiaDocument>(_settings)) as ILoteriaRepository<T>;
                default:
                    throw new InvalidOperationException("Tipo de loteria inválida");
            }
        }
    }

}
