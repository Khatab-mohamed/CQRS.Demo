using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//  MediatR Method

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddControllers();
    
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
