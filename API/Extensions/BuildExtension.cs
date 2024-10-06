using Infrastructure.Configs.MongoConfigs;
using Microsoft.Extensions.Options;
using OpenTelemetry.Metrics;

namespace API.Extensions
{
	public static class BuildExtension
	{
		public static void AddCrossOrigin(this WebApplicationBuilder builder)
		{
			builder.Services.AddCors(cors =>
			{
				cors.AddDefaultPolicy(builder =>
				{
					builder.AllowAnyOrigin();
					builder.AllowAnyMethod();
				});
			});
		}
		public static void AddMongoConfiguration(this WebApplicationBuilder builder)
		{
			builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
			builder.Services.AddSingleton(serviceProvider =>
					serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);
			//Console.WriteLine(builder.Configuration.GetSection("MongoDbSettings:ConnectionString").Value);
		}

		public static void AddDocumentation(this WebApplicationBuilder builder)
		{
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
		}

		/*public static void AddHealthChecks(this WebApplicationBuilder builder)
		{
			builder.Services.AddHealthChecks()
			 .AddMongoDb(builder.Configuration["MongoDbSettings:ConnectionString"], name: "Mongo Log")
			 .ForwardToPrometheus();
		}*/

		public static void AddTelemetriPrometheus(this WebApplicationBuilder builder)
		{
			builder.Services.AddOpenTelemetry()
			.WithMetrics(builder =>
			{
				builder.AddPrometheusExporter();
				builder.AddMeter("Microsoft.AspNetCore.Hosting",
					"Microsoft.AspNetCore.Server.Kestrel");
				builder.AddView("http.server.request.duration",
					new ExplicitBucketHistogramConfiguration
					{
						Boundaries = new double[] { 0, 0.005, 0.01, 0.025, 0.05,
							  0.075, 0.1, 0.25, 0.5, 0.75, 1, 2.5, 5, 7.5, 10 }
					});
			});
		}
	}
}
