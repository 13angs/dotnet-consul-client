# Dotnet consul register

## Usage:

- install the package

```bash
dotnet add package 13angs.Consul.Client --version 0.0.1
```

- register the service in DI container

```csharp
var consulConfig = Configuration.GetConsulConfig();
builder.Services.RegisterConsulServices(consulConfig);
```

- update the appsetting.json

```json
{
    "ConsulConfig": {
        "ServiceDiscoveryAddress": "http://dcc-consul-server1:8500",
        "ServiceAddress": "http://localhost:5117",
        "ServiceName": "dcc-sample",
        "ServiceId": "v1"
    }
}
```

- Done!.

# References
1. https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli
