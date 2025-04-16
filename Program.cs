using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProposalOrchestrator.WorkflowEngine;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddTransient<Workflow>();
    })
    .Build();

using var scope = host.Services.CreateScope();
var workflow = scope.ServiceProvider.GetRequiredService<Workflow>();
await workflow.RunAsync();