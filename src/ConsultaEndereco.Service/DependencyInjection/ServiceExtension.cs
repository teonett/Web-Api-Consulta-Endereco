using ConsultaEndereco.Core.Services;
using ConsultaEndereco.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsultaEndereco.Service.DependencyInjection
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddEnderecoServices(this IServiceCollection services)
        {
            services.AddScoped<ICepLaService, CepLaService>();
            services.AddScoped<ICorreiosService, CorreiosService>();
            services.AddScoped<IViaCepService, ViaCepService>();
            services.AddScoped<IPostmonService, PostmonService>();

            return services;
        }
    }
}
