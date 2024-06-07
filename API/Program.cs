using BLL.DI;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApplicationDependencies(builder.Configuration);

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();