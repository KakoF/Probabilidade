using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.Abstracts;
using Infrastructure.Configs.MongoConfigs;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Factory
{
    internal class LoteriaServiceFactory<T, TInterface> : ILoteriaServiceFactory<T, TInterface> where T : LoteriaAbstract where TInterface : ILoteriaService<T>
    {

        private readonly MongoDbSettings _settings;
        public LoteriaServiceFactory(MongoDbSettings settings)
        {
            _settings = settings;
        }

        public TInterface FactoryService(eLoteria loteria)
        {
            switch (loteria)
            {
                case eLoteria.DiaDeSorte:
                    return (TInterface)(new DiaDeSorteService(new DiaDeSorteRepository(new MongoRepository<DiaDeSorteDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.DuplaSena:
                    return (TInterface)(new DuplaSenaService(new DuplaSenaRepository(new MongoRepository<DuplaSenaDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.Federal:
                    return (TInterface)(new FederalService(new FederalRepository(new MongoRepository<FederalDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.LotoFacil:
                    return (TInterface)(new LotoFacilService(new LotoFacilRepository(new MongoRepository<LotoFacilDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.LotoMania:
                    return (TInterface)(new LotoManiaService(new LotoManiaRepository(new MongoRepository<LotoManiaDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.MaisMilionaria:
                    return (TInterface)(new MaisMilionariaService(new MaisMilionariaRepository(new MongoRepository<MaisMilionariaDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.MegaSena:
                    return (TInterface)(new MegaSenaService(new MegaSenaRepository(new MongoRepository<MegaSenaDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.Quina:
                    return (TInterface)(new QuinaService(new QuinaRepository(new MongoRepository<QuinaDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.SuperSete:
                    return (TInterface)(new SuperSeteService(new SuperSeteRepository(new MongoRepository<SuperSeteDocument>(_settings))) as ILoteriaModelService<T>);
                case eLoteria.TimeMania:
                    return (TInterface)(new TimeManiaService(new TimeManiaRepository(new MongoRepository<TimeManiaDocument>(_settings))) as ILoteriaModelService<T>);
                default:
                    throw new InvalidOperationException("Tipo de loteria inválida");
            }
        }


    }

}