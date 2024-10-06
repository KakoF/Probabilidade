namespace API.Extensions
{
	public static class AppExtension
	{
		public static void ConfigureDevEnvironment(this WebApplication app)
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		public static void UsePrometheus(this WebApplication app)
		{
			app.MapPrometheusScrapingEndpoint();
		}
	}
}
