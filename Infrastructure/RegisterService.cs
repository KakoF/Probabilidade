﻿using Domain.Documents;
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