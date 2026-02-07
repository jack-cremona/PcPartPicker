using Microsoft.AspNetCore.Mvc;
using PcPartPickerProject;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers(); //genera un progetto con già i controller

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization(); //esistono delle classi controller che dovrai mappare per le API

app.MapControllers();

app.MapScalarApiReference();
app.Run();