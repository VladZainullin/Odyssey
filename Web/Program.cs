using Application;
using Identification;
using Persistence;
using Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPersistenceServices()
    .AddIdentificationServicesService(builder.Configuration)
    .AddApplicationServices()
    .AddWebApiServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

await app.RunAsync();