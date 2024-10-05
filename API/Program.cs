using API.Helpers;
using Service;
using Infrastructure;
using Infrastructure.Configs.MongoConfigs;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Prometheus;
using HealthChecks.UI.Client;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
  .AddNewtonsoftJson(options => options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore)
  .AddJsonOptions(opt =>
  {
      opt.JsonSerializerOptions.Converters.Add(new OptOutJsonConverterFactory(new JsonStringEnumConverter()));
  });


builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.AddSingleton(serviceProvider =>
        serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.ConfigureService(builder.Configuration);
builder.Services.ConfigureInfraStructure();


builder.Services.AddHealthChecks()
		 .AddMongoDb(builder.Configuration["MongoDbSettings:ConnectionString"], name: "Mongo Log")
		 .ForwardToPrometheus();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/*INICIO DA CONFIGURA��O - PROMETHEUS*/
// Custom Metrics to count requests for each endpoint and the method
var counter = Metrics.CreateCounter("SimianApplicationEndpointCounter", "Counts requests to the SimianApplication API endpoints",
	new CounterConfiguration
	{
		LabelNames = new[] { "method", "endpoint" }
	});

app.Use((context, next) =>
{
	counter.WithLabels(context.Request.Method, context.Request.Path).Inc();
	return next();
});

// Use the prometheus middleware
app.UseMetricServer();
app.UseHttpMetrics();
app.MapHealthChecks("/health", new HealthCheckOptions
{
	ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

/*PROMETHEUS*/

app.UseAuthorization();

app.MapControllers();

app.Run();
