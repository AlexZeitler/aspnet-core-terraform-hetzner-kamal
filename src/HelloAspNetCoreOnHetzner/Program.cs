using HelloAspNetCoreOnHetzner;
using HelloAspNetCoreOnHetzner.Core;

var configuration = new ConfigurationManager()
  .AddJsonFile("appsettings.json")
  .AddJsonFile("appsettings.Development.json")
  .Build();

var builder = ConfigureHost.GetHostBuilder(
  configuration,
  services => { }
);

builder.AddLogging();
builder
  .Build()
  .Run();
