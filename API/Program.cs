using API.Helpers;
using Service;
using Infrastructure;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddCrossOrigin();
builder.AddMongoConfiguration();
builder.AddDocumentation();
builder.AddTelemetriPrometheus();
//builder.AddHealthChecks();

builder.Services.AddControllers()
  .AddNewtonsoftJson(options => options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore)
  .AddJsonOptions(opt =>
  {
      opt.JsonSerializerOptions.Converters.Add(new OptOutJsonConverterFactory(new JsonStringEnumConverter()));
  });

builder.Services.ConfigureService(builder.Configuration);
builder.Services.ConfigureInfraStructure();


var app = builder.Build();

if (app.Environment.IsDevelopment())
	app.ConfigureDevEnvironment();

app.UseCors();
//app.UseHttpsRedirection();

app.UsePrometheus();

app.UseAuthorization();
app.MapControllers();
app.Run();
