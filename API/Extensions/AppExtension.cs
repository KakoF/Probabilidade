using API.Helpers.MetricsHelper;
using Prometheus;

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
			app.UseHealthChecksPrometheusExporter("/metrics");
			app.UseHttpMetrics();
			
			//Helpers para metricas
			var cpuMetrics = new CpuMetricsHelper();
			var memoryMetrics = new MemoryMetricsHelper();
		}
	}
}
