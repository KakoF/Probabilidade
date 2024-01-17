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
            services.AddScoped<IDiaDeSorteRepository, DiaDeSorteRepository>();
            services.AddScoped<IDuplaSenaRepository, DuplaSenaRepository>();
            services.AddScoped<IFederalRepository, FederalRepository>();
            services.AddScoped<ILotoFacilRepository, LotoFacilRepository>();
            services.AddScoped<ILotoManiaRepository, LotoManiaRepository>();
            services.AddScoped<IMaisMilionariaRepository, MaisMilionariaRepository>();
            services.AddScoped<IMegaSenaRepository, MegaSenaRepository>();
            services.AddScoped<IQuinaRepository, QuinaRepository>();
            services.AddScoped<ISuperSeteRepository, SuperSeteRepository>();
            services.AddScoped<ITimeManiaRepository, TimeManiaRepository>();

            services.AddScoped(typeof(ILoteriaRepositoryFactory<LoteriaDocument, ILoteriaRepository<LoteriaDocument>>), typeof(LoteriaRepositoryFactory<LoteriaDocument, ILoteriaRepository<LoteriaDocument>>));
        }
    }
}