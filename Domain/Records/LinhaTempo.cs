using Domain.Models.Abstracts;

namespace Domain.Records
{
    public class LinhaTempo
    {
        public string Sorteio { get; private set; }
        public int Numero { get; private set; }

        public IList<DateTime> Datas { get; private set; }


        public LinhaTempo(int numero, IEnumerable<LoteriaAbstract> loterias)
        {
            Numero = numero;
            if (loterias == null || !loterias.Any())
                return;
            Sorteio = loterias.FirstOrDefault().Nome;
            Datas = new List<DateTime>();
            foreach (var l in loterias)
                Datas.Add(Convert.ToDateTime(l.Data));

            Datas = Datas.OrderBy(l => l.Date).ToList();


        }
    }
}
