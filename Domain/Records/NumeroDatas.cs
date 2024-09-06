namespace Domain.Records
{
	public class NumeroDatas
	{
		public int Numero { get; set; }
		public IList<DateTime> Datas { get; init; } = new List<DateTime>();
	}
}
