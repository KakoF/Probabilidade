using Domain.Models.Abstracts;

namespace Domain.Records
{
	public class LinhaDoTempo
	{
		public string Sorteio { get; private set; }
		public List<NumeroDatas> Numeros { get; init; } = new List<NumeroDatas>();

		public LinhaDoTempo(List<int> numeros, IEnumerable<IEnumerable<SorteioAbstract>> sorteios)
		{
			if (sorteios == null || !sorteios.Any())
				return;

			Sorteio = sorteios?.FirstOrDefault()?.FirstOrDefault()?.Nome;
			foreach (var sorteio in sorteios.Select((value, i) => new { i, value }))
			{
				var NumeroData = new NumeroDatas();
				NumeroData.Numero = numeros[sorteio.i];
				foreach (var item in sorteio.value)
					NumeroData.Datas.Add(Convert.ToDateTime(item.Data));

				Numeros.Add(NumeroData);
			}
		}
	}
}
