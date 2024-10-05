namespace Domain.Records.Requests
{
	public class LinhaTempoRequest
	{
		public int[] Numeros { get; set; }
		public DateTime DataInicio { get; set; } = DateTime.Now.AddYears(-1);
	}
}
