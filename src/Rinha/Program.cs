using Rinha.Dtos;
using Rinha.Configuration;
using Rinha.Services; 
using Rinha.Services.Interfaces; 

var builder = WebApplication.CreateBuilder(args);
// var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options => {
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, JsonContext.Default);
});

builder.Services.AddSingleton<IFraudDetectionService, FraudDetectionService>();

var app = builder.Build();

app.MapGet("/ready", () => Results.Ok());

app.MapPost("/fraud-score", (FraudScoreRequest request, IFraudDetectionService service) =>
{

});

app.UseCors();

await app.RunAsync();
