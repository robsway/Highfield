using Highfield.Connectors;
using Highfield.Connectors.Interfaces;
using Highfield.Entities;
using Highfield.Repositories;
using Highfield.Repositories.Interfaces;
using Highfield.Services;
using Highfield.Services.Interfaces;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient(
    nameof(User),
    client => client.BaseAddress = new Uri(builder.Configuration.GetConnectionString("HighfieldRecruitment")));

builder.Services.AddSingleton<IUsersConnector, UsersConnector>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IUsersRepository, UsersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/api/UsersAgedByTwentyYears", async (IUsersService usersService) =>
{ 
    return await usersService.GetAllUsersAgedByTwentyYearsAsync();
});

app.MapGet("/api/FavouriteUserColours", async (IUsersService usersService) =>
{
    return await usersService.GetFavouriteUserColoursAsync();
});

app.MapPost("/api/ResetRepository", async (IUsersRepository usersRepository) =>
{
    await usersRepository.ResetAsync();
});

var defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("index.html");
app.UseDefaultFiles(defaultFilesOptions);

app.UseStaticFiles();

app.Run();
