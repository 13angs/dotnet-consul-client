using Consul.Client;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

var consulConfig = Configuration.GetConsulConfig();
builder.Services.RegisterConsulServices(consulConfig);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
