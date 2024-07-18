using API.DI;
using API.Extensions;
using BLL.DI;
using BLL.GrpcServices;
using BLL.MappingConfigurations;
using Bogus;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console());

var services = builder.Services;

services.AddApplicationDependencies(builder.Configuration);
services.AddApiDependencies(builder.Configuration);

GlobalMappingSettings.SetMapper();

services.AddControllers();

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapGrpcService<CatalogGrpcServiceController>();
app.MapControllers();

await app.RunAsync();