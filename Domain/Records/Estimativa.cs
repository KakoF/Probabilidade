using Domain.Enums;
using Domain.Models.Abstracts;
using System.Collections.Generic;

namespace Domain.Records
{
    public class Estimativa
    {
        public int TotalSorteios { get; set; }
        public IList<Probabilidade> Probabilidade { get; private set; }

        public Estimativa(IEnumerable<LoteriaAbstract> list)
        {
            
            Probabilidade = new List<Probabilidade>();
            CalcularEstimativa(list);
        }

        private void CalcularEstimativa(IEnumerable<LoteriaAbstract> loterias)
        {
            TotalSorteios = loterias.Select(x => x.Dezenas).Count();
            var numeros = loterias.Select(x => x.Dezenas).AsEnumerable().SelectMany(s => s).Distinct();
            foreach (var item in numeros)
            {
                var aparicoes = loterias.Count(f => f.Dezenas.Any(x => x.Equals(item)));
                Probabilidade.Add(new Probabilidade(Convert.ToInt32(item), aparicoes, ((decimal)aparicoes / (decimal)TotalSorteios) * 100));
            }

            Probabilidade = Probabilidade.OrderBy(x => x.numero).ToList();
        }
    }
    public record Probabilidade(int numero, int totalSorteios, decimal porcentagem);

}
