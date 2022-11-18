using Microsoft.Extensions.DependencyInjection;

namespace Consul.Client
{
    public static class ServiceDiscoveryExtensions
    {
        public static void RegisterConsulServices(this IServiceCollection services, ConsulConfig consulConfig)
        {
            if (consulConfig == null)
            {
                throw new ArgumentNullException(nameof(ConsulConfig));
            }

            var consulClient = CreateConsulClient(consulConfig);

            services.AddSingleton(consulConfig);
            services.AddHostedService<ConsulServiceDiscoveryHostedService>();
            services.AddSingleton<IConsulClient, ConsulClient>(p => consulClient);
        }

        private static ConsulClient CreateConsulClient(ConsulConfig ConsulConfig)
        {
            return new ConsulClient(config =>
            {
                config.Address = ConsulConfig.ServiceDiscoveryAddress;
            });
        }
    }
}