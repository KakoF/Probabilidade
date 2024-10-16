﻿using Domain.Documents;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using Service.Services.Factory;

namespace Service
{
    public static class RegisterService
    {
        public static void ConfigureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(ISorteioServiceFactory<SorteioAbstract, ISorteioService<SorteioAbstract>>), typeof(LoteriaServiceFactory<SorteioAbstract, ISorteioService<SorteioAbstract>>));
            services.AddScoped(typeof(ISorteioModelService<SorteioAbstract>), typeof(SorteioModelService<SorteioDocument, SorteioAbstract>));
            services.AddScoped(typeof(ILoteriasExecuteCommand<SorteioAbstract>), typeof(SorteioExecuteCommand<SorteioAbstract>));
            services.AddScoped<IDiaDeSorteService, DiaDeSorteService>();
            services.AddScoped<IFederalService, FederalService>();
            services.AddScoped<ILotoFacilService, LotoFacilService>();
            services.AddScoped<ILotoManiaService, LotoManiaService>();
            services.AddScoped<IMaisMilionariaService, MaisMilionariaService>();
            services.AddScoped<IMegaSenaService, MegaSenaService>();
            services.AddScoped<IQuinaService, QuinaService>();
            services.AddScoped<ISuperSeteService, SuperSeteService>();
            services.AddScoped<ITimeManiaService, TimeManiaService>();

        }
    }
}