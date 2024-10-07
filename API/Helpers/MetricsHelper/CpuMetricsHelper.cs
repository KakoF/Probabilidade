
namespace API.Helpers.MetricsHelper
{
	public class CpuMetricsHelper
	{
		/*private static readonly Gauge cpuUsageGauge = Metrics.CreateGauge("cpu_usage_percentage", "Current CPU usage percentage.");

		private Timer _timer;
		private TimeSpan _lastTotalProcessorTime;
		private DateTime _lastTimeStamp;

		public CpuMetricsHelper()
		{
			// Inicia o timer para atualizar a métrica periodicamente
			_lastTotalProcessorTime = Process.GetCurrentProcess().TotalProcessorTime;
			_lastTimeStamp = DateTime.UtcNow;

			_timer = new Timer(UpdateCpuMetrics, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
		}

		private void UpdateCpuMetrics(object state)
		{
			// Calcula a porcentagem de uso de CPU do processo atual
			var currentProcess = Process.GetCurrentProcess();
			var currentTotalProcessorTime = currentProcess.TotalProcessorTime;
			var currentTimeStamp = DateTime.UtcNow;

			var cpuUsedMs = (currentTotalProcessorTime - _lastTotalProcessorTime).TotalMilliseconds;
			var timeElapsedMs = (currentTimeStamp - _lastTimeStamp).TotalMilliseconds;
			var cpuUsageTotal = cpuUsedMs / (Environment.ProcessorCount * timeElapsedMs);

			// Atualiza a métrica
			cpuUsageGauge.Set(cpuUsageTotal * 100);

			// Atualiza os valores para o próximo cálculo
			_lastTotalProcessorTime = currentTotalProcessorTime;
			_lastTimeStamp = currentTimeStamp;
		}
		public void Dispose()
		{
			_timer?.Dispose();
		}*/
	}
}