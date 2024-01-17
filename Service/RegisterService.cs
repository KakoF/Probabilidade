using Domain.Documents;
using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
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
            services.AddScoped(typeof(ILoteriaServiceFactory<LoteriaAbstract, ILoteriaService<LoteriaAbstract>>), typeof(LoteriaServiceFactory<LoteriaAbstract, ILoteriaService<LoteriaAbstract>>));
            services.AddScoped(typeof(ILoteriaModelService<LoteriaAbstract>), typeof(LoteriaModelService<LoteriaDocument, LoteriaAbstract>));
            //services.AddScoped(typeof(ILoteriaService<LoteriaAbstract>));
            //services.AddScoped<ILoteriaService<LoteriaAbstract>, LoteriaService<LoteriaAbstract>>();
            services.AddScoped<IDiaDeSorteService, DiaDeSorteService>();
            services.AddScoped<IFederalService, FederalService>();
            services.AddScoped<ILotoFacilService, LotoFacilService>();
            services.AddScoped<ILotoManiaService, LotoManiaService>();
            services.AddScoped<IMaisMilionariaService, MaisMilionariaService>();
            services.AddScoped<IMegaSenaService, MegaSenaService>();
            services.AddScoped<IQuinaService, QuinaService>();
            services.AddScoped<ISuperSeteService, SuperSeteService>();
            services.AddScoped<ITimeManiaService, TimeManiaService>();

            //services.AddScoped(typeof(ILoteriaService<LoteriaAbstract>), typeof(LoteriaService<LoteriaAbstract>));
            //services.AddScoped<ILoteriaService<LoteriaAbstract>, LoteriaService<LoteriaAbstract>>();
            //services.AddScoped<ILoteriaService, LoteriaService>();
            //services.AddScoped(typeof(ILoteriaService<LoteriaAbstract>), typeof(LoteriaService<LoteriaAbstract>));

            //services.AddScoped(typeof(ILoteriaModelService<LoteriaAbstract>), typeof(LoteriaModelService<LoteriaDocument, LoteriaAbstract>));
            
        }
    }
}