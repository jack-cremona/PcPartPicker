using Microsoft.AspNetCore.Mvc;
using PcPartPickerProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

Build build = new Build();

app.MapPost("/addMobo", ([FromBody]  string name) =>
{
    Motherboard m = DB.motherboards.SingleOrDefault(m => m.model == name);
    if (build.IsCompatible(m))
    {
        build.motherboard = m;
        Console.WriteLine("motherboard added because is compatible");
        return Results.Ok();
    }
    else
    {
        Console.WriteLine("errore Motherboard non compatibile");
        return Results.BadRequest("motherboard non compatibile");
    }
});

app.MapPost("/addCpu", ([FromBody] string name) =>
{
    Cpu c = DB.cpus.SingleOrDefault(c => c.model == name);
    if (build.IsCompatible(c))
    {
        build.processor = c;
        Console.WriteLine("cpu added because in compatible");
        return Results.Ok();
    }
    else
    {
        Console.WriteLine("errore Cpu non compatibile");
        return Results.BadRequest("cpu non compatibile");
    }
});

app.MapPost("/addCpuCooler", ([FromBody] string name) =>
{
    CpuCooler c = DB.cpuCoolers.SingleOrDefault(c => c.model == name);
    if (build.IsCompatible(c))
    {
        build.cpuCooler = c;
        Console.WriteLine("cpu cooler added because in compatible");
        return Results.Ok();
        
    }
    else
    {
        Console.WriteLine("errore Cpu cooler non compatibile");
        return Results.BadRequest("cpu cooler non compatibile");
    }
});

app.MapGet("/getMobo", () =>
{
    return DB.motherboards;
});

app.MapGet("/getCpu", () =>
{
    return DB.cpus;
});

app.MapGet("/getCpuCooler", () =>
{
    return DB.cpuCoolers;
});

app.Run();