using Infrastructure.Configs.MongoConfigs;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

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

		public static void AddHealthChecks(this WebApplicationBuilder builder)
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
		}

		
	}
}
