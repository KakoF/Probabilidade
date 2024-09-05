using Domain.Models.Abstracts;

namespace Domain.Records
{
    public class LinhaDoTempo
    {
        public string Sorteio { get; private set; }
        public int Numero { get; private set; }

        public IList<DateTime> Datas { get; private set; }


        public LinhaDoTempo(int numero, IEnumerable<SorteioAbstract> sorteios)
        {
            Numero = numero;
            if (sorteios == null || !sorteios.Any())
                return;
            Sorteio = sorteios.FirstOrDefault().Nome;
            Datas = new List<DateTime>();
            foreach (var sorteio in sorteios)
                Datas.Add(Convert.ToDateTime(sorteio.Data));

            Datas = Datas.OrderBy(l => l.Date).ToList();


        }
    }
}
