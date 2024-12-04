using GameStore.Api.Dtos;
using GameStore.Api.Endpoints;
using Microsoft.AspNetCore.Mvc.ModelBinding;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        
     app.MapGamesEndpoints();
     app.Run();
    }

    private static void WithName(string v)
    {
        throw new NotImplementedException();
    }
}