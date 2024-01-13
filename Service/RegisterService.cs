using Domain.Documents;
using Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Service
{
    public static class RegisterService
    {
        public static void ConfigureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILoteriaService<LoteriaDocument>, LoteriaService<LoteriaDocument>>();
        }
    }
}