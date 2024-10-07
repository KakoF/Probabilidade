using Infrastructure.Configs.MongoConfigs;
using Microsoft.Extensions.Diagnostics.HealthChecks;
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

		public static void AddTelemetriPrometheus(this WebApplicationBuilder builder)
		{

			builder.Services.AddOpenTelemetry()
			.WithMetrics(builder =>
			{
				builder.AddRuntimeInstrumentation();
				builder.AddMeter("Microsoft.AspNetCore.Hosting"
					,"Microsoft.AspNetCore.Server.Kestrel"
					, "Microsoft.AspNetCore.Http.Connections"
					, "Microsoft.AspNetCore.Routing"
					, "Microsoft.AspNetCore.Diagnostics"
					, "Microsoft.AspNetCore.RateLimiting");
				/*builder.AddView("http.server.request.duration",
					new ExplicitBucketHistogramConfiguration
					{
						Boundaries = new double[] { 0, 0.005, 0.01, 0.025, 0.05,
							  0.075, 0.1, 0.25, 0.5, 0.75, 1, 2.5, 5, 7.5, 10 }
					});*/
				builder.AddPrometheusExporter();
			});
		}

		/*public static void AddHealthChecks(this WebApplicationBuilder builder)
		{

			builder.Services.AddHealthChecks()
			.AddCheck("self", () => HealthCheckResult.Healthy())
			
			.AddProcessAllocatedMemoryHealthCheck(maximumMegabytesAllocated: 512 * 1024 * 1024, name: "process_memory") // 512MB
			.AddPrivateMemoryHealthCheck(maximumMemoryBytes: 1024 * 1024 * 1024, name: "private_memory")// 1GB
			.AddMongoDb(
				mongodbConnectionString: builder.Configuration["MongoDbSettings:ConnectionString"], // String de conexão do MongoDB
				name: "mongodb",
				failureStatus: Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Unhealthy,
				tags: new string[] { "db", "mongodb" }
			);
		}*/


		}
	}
