using Domain.Enums;
using Domain.Models.Abstracts;
using System.Collections.Generic;

namespace Domain.Records
{
    public class Estimativa
    {
        public string Sorteio { get; private set; }
        public int TotalSorteios { get; private set; }
        public IList<Probabilidade> Probabilidade { get; private set; }

        public Estimativa(IEnumerable<LoteriaAbstract> list)
        {
            
            Probabilidade = new List<Probabilidade>();
            CalcularEstimativa(list);
        }

        private void CalcularEstimativa(IEnumerable<LoteriaAbstract> loterias)
        {
            if (loterias == null || !loterias.Any())
                return;
            Sorteio = loterias.FirstOrDefault().Nome;
            TotalSorteios = loterias.Select(x => x.Dezenas).Count();
            var numeros = loterias.Select(x => x.Dezenas).AsEnumerable().SelectMany(s => s).Distinct();
            for (int i = Convert.ToInt32(numeros.Min()); i <= Convert.ToInt64(numeros.Max()); i++)
            {
                var aparicoes = loterias.Count(f => f.Dezenas.Any(x => Convert.ToInt32(x).Equals(i)));
                Probabilidade.Add(new Probabilidade(Convert.ToInt32(i), aparicoes, ((decimal)aparicoes / (decimal)TotalSorteios) * 100));
            }
        }
    }
    public record Probabilidade(int numero, int totalSorteios, decimal porcentagem);

}
