﻿using Domain.Models.Abstracts;

namespace Domain.Records
{
    public class ProbabilidadeCalculada
    {
        public string Sorteio { get; private set; }
        public int TotalSorteios { get; private set; }
        public IList<Probabilidade> Probabilidade { get; private set; }

        public ProbabilidadeCalculada(IEnumerable<SorteioAbstract> list)
        {
            
            Probabilidade = new List<Probabilidade>();
            CalcularProbabilidade(list);
        }

        private void CalcularProbabilidade(IEnumerable<SorteioAbstract> sorteios)
        {
			Sorteio = sorteios.FirstOrDefault().Nome;
            TotalSorteios = sorteios.Select(x => x.Dezenas).Count();
            var numeros = sorteios.Select(x => x.Dezenas).AsEnumerable().SelectMany(s => s).Distinct();
            for (int i = Convert.ToInt16(numeros.Min()); i <= Convert.ToInt16(numeros.Max()); i++)
            {
                var aparicoes = sorteios.Count(f => f.Dezenas.Any(x => Convert.ToInt32(x).Equals(i)));
                Probabilidade.Add(new Probabilidade(Convert.ToInt32(i), aparicoes, ((decimal)aparicoes / (decimal)TotalSorteios) * 100));
            }
        }
    }
}
