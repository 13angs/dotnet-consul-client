using Microsoft.Extensions.Configuration;

namespace Consul.Client
{
    public static class ConsulConfigExtensions
  {
    public static ConsulConfig GetConsulConfig(this IConfiguration configuration)
    {
      if (configuration == null)
      {
        throw new ArgumentNullException(nameof(configuration));
      }

      var consulConfig = new ConsulConfig
      {
        ServiceDiscoveryAddress = new System.Uri(configuration["ConsulConfig:serviceDiscoveryAddress"]),
        ServiceAddress = new System.Uri(configuration["ConsulConfig:serviceAddress"]),
        ServiceName = configuration["ConsulConfig:serviceName"],
        ServiceId = configuration["ConsulConfig:serviceId"]
      };

      return consulConfig;
    }
  }
}