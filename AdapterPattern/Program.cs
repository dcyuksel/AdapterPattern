using AdapterPattern.Adapters;
using AdapterPattern.Export;
using AdapterPattern.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<IUserExportAdapterService, UserExportAdapterService>();
builder.Services.AddScoped<IUserExportService, UserExportService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
using IHost host = builder.Build();

Run(host.Services);

await host.RunAsync();

static void Run(IServiceProvider hostProvider)
{
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;

    var repository = provider.GetRequiredService<IUserRepository>();
    var users = repository.GetUsers();

    var adapter = provider.GetRequiredService<IUserExportAdapterService>();
    adapter.Export(users);
}
