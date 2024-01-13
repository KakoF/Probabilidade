using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Infrastructure.Configs.MongoConfigs;

namespace Infrastructure.Repository.Factory
{
    public class LoteriaRepositoryFactory<T, TInterface> : ILoteriaRepositoryFactory<T, TInterface> where T : LoteriaDocument where TInterface : ILoteriaRepository<T>
    {
        private readonly MongoDbSettings _settings;
        public LoteriaRepositoryFactory(MongoDbSettings settings)
        {
            _settings = settings;
        }

        public TInterface FactoryRepository(eLoteria loteria)
        {
            switch (loteria)
            {
                case eLoteria.DuplaSena:
                    var teste = (TInterface)(new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings)) as ILoteriaRepository<T>);
                    //var teste2 = (ILoteriaRepository<FederalDocument>)(new FederalRepository(new MongoRepository<FederalDocument>(_settings)));
                    //var teste44 = teste2.GetLastAsync().Result;
                    return (TInterface)(new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings)) as ILoteriaRepository<T>);
                    //return (TInterface)(new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings)) as ILoteriaRepository<DuplaSenaDocument>);
                case eLoteria.Federal:
                    return (TInterface)(new FederalRepository(new MongoRepository<FederalDocument>(_settings)) as IFederalRepository);
                case eLoteria.LotoFacil:
                    return (TInterface)(new LotoFacilRepository(new MongoRepository<LotoFacilDocument>(_settings)) as ILotoFacilRepository);
                case eLoteria.LotoMania:
                    return (TInterface)(new LotoManiaRepository(new MongoRepository<LotoManiaDocument>(_settings)) as ILotoManiaRepository);
                case eLoteria.MaisMilionaria:
                    return (TInterface)(new MaisMilionariaRepository(new MongoRepository<MaisMilionariaDocument>(_settings)) as IMaisMilionariaRepository);
                case eLoteria.MegaSena:
                    return (TInterface)(new MegaSenaRepository(new MongoRepository<MegaSenaDocument>(_settings)) as IMegaSenaRepository);
                case eLoteria.Quina:
                    return (TInterface)(new QuinaRepository(new MongoRepository<QuinaDocument>(_settings)) as IQuinaRepository);
                case eLoteria.SuperSete:
                    return (TInterface)(new SuperSeteRepository(new MongoRepository<SuperSeteDocument>(_settings)) as ISuperSeteRepository);
                case eLoteria.TimeMania:
                    return (TInterface)(new TimeManiaRepository(new MongoRepository<TimeManiaDocument>(_settings)) as ITimeManiaRepository);
                default:
                    throw new InvalidOperationException("Tipo de loteria inválida");
            }
        }

       
    }

}
