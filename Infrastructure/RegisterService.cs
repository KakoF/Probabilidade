using Domain.Documents;
using Domain.Interfaces.Repository;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfraStructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
            //services.AddScoped(typeof(ILoteriaRepository<>), typeof(LoteriaRepository<>));
            //services.AddScoped(typeof(ILoteriaRepository<LoteriaDocument>), typeof(LoteriaRepository<LoteriaDocument>));




            //services.AddScoped<LoteriaRepository, DuplaSenaRepository>();
            //services.AddScoped(typeof(LoteriaRepository<LoteriaDocument>), typeof(DuplaSenaRepository));

            //services.AddScoped<ILoteriaRepository<LoteriaDocument>, LoteriaRepository<LoteriaDocument>>();
            //services.AddScoped<IStorageTableQueryHelper>(sp => sp.GetRequiredService<LoteriaRepository>());

            //services.AddScoped<ILoteriaRepository>, <LoteriaRepository>);
            //services.AddScoped<ILoteriaRepository>, <LoteriaRepository>);
            services.AddScoped<IDuplaSenaRepository<DuplaSenaDocument>, DuplaSenaRepository>();
            services.AddScoped<IFederalRepository<FederalDocument>, FederalRepository>();
            services.AddScoped<ILotoFacilRepository<LotoFacilDocument>, LotoFacilRepository>();
            services.AddScoped<ILotoManiaRepository<LotoManiaDocument>, LotoManiaRepository>();
            services.AddScoped<IMaisMilionariaRepository<MaisMilionariaDocument>, MaisMilionariaRepository>();
            services.AddScoped<IMegaSenaRepository<MegaSenaDocument>, MegaSenaRepository>();
            services.AddScoped<IQuinaRepository<QuinaDocument>, QuinaRepository>();
            services.AddScoped<ISuperSeteRepository<SuperSeteDocument>, SuperSeteRepository>();
            services.AddScoped<ITimeManiaRepository<TimeManiaDocument>, TimeManiaRepository>();
        }
    }
}