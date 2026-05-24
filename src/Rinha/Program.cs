var builder = WebApplication.CreateBuilder(args);
// var builder = WebApplication.CreateSlimBuilder(args);
var app = builder.Build();

app.MapGet("/ready", () => Results.Ok());

app.MapPost("/fraud-score", () =>
{

});

app.UseCors();

await app.RunAsync();
