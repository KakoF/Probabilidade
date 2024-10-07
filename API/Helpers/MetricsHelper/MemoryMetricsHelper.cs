
namespace API.Helpers.MetricsHelper
{
	public class MemoryMetricsHelper
	{
		/*private static readonly Gauge memoryWorkingSetGauge = Metrics.CreateGauge("memory_working_set_bytes", "Current memory usage in bytes (Working Set).");

		// Cria um Gauge para capturar o uso de memória virtual
		private static readonly Gauge memoryVirtualSetGauge = Metrics.CreateGauge("memory_virtual_set_bytes", "Current virtual memory usage in bytes.");

		private Timer _timer;

		public MemoryMetricsHelper()
		{
			// Configura um timer para capturar as métricas em intervalos regulares
			_timer = new Timer(UpdateMemoryMetrics, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
		}

		private void UpdateMemoryMetrics(object state)
		{
			var currentProcess = Process.GetCurrentProcess();

			// Captura o Working Set (memória física usada) e atualiza a métrica
			var memoryWorkingSet = currentProcess.WorkingSet64;  // Em bytes
			memoryWorkingSetGauge.Set(memoryWorkingSet);

			// Captura o uso de memória virtual e atualiza a métrica
			var memoryVirtualSet = currentProcess.VirtualMemorySize64;  // Em bytes
			memoryVirtualSetGauge.Set(memoryVirtualSet);
		}

		public void Dispose()
		{
			_timer?.Dispose();
		}*/
	}
}