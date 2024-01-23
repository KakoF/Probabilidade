using Domain.Models.Abstracts;

namespace Domain.Records
{
    public class LinhaDoTempo
    {
        public string Loteria { get; private set; }
        public int Numero { get; private set; }

        public IList<DateTime> Datas { get; private set; }


        public LinhaDoTempo(int numero, IEnumerable<LoteriaAbstract> loterias)
        {
            Numero = numero;
            if (loterias == null || !loterias.Any())
                return;
            Loteria = loterias.FirstOrDefault().Nome;
            Datas = new List<DateTime>();
            foreach (var l in loterias)
                Datas.Add(Convert.ToDateTime(l.Data));

            Datas = Datas.OrderBy(l => l.Date).ToList();


        }
    }
}
