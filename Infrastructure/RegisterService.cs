using Domain.Documents;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Infrastructure.Repository;
using Infrastructure.Repository.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfraStructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            /*services.AddScoped<ILoteriaRepository<DuplaSenaDocument>, DuplaSenaRepository>();
            services.AddScoped<ILoteriaRepository<FederalDocument>, FederalRepository>();
            services.AddScoped<ILoteriaRepository<LotoFacilDocument>, LotoFacilRepository>();
            services.AddScoped<ILoteriaRepository<LotoManiaDocument>, LotoManiaRepository>();
            services.AddScoped<ILoteriaRepository<MaisMilionariaDocument>, MaisMilionariaRepository>();
            services.AddScoped<ILoteriaRepository<MegaSenaDocument>, MegaSenaRepository>();
            services.AddScoped<ILoteriaRepository<QuinaDocument>, QuinaRepository>();
            services.AddScoped<ILoteriaRepository<SuperSeteDocument>, SuperSeteRepository>();
            services.AddScoped<ILoteriaRepository<TimeManiaDocument>, TimeManiaRepository>();*/


            services.AddScoped<IDuplaSenaRepository, DuplaSenaRepository>();
            services.AddScoped<IFederalRepository, FederalRepository>();
            services.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
            services.AddScoped<ILotoManiaRepository, LotoManiaRepository>();
            services.AddScoped<IMaisMilionariaRepository, MaisMilionariaRepository>();
            services.AddScoped<IMegaSenaRepository, MegaSenaRepository>();
            services.AddScoped<IQuinaRepository, QuinaRepository>();
            services.AddScoped<ISuperSeteRepository, SuperSeteRepository>();
            services.AddScoped<ITimeManiaRepository, TimeManiaRepository>();

            services.AddScoped(typeof(ILoteriaRepositoryFactory<LoteriaDocument>), typeof(LoteriaRepositoryFactory<LoteriaDocument>));
        }
    }
}