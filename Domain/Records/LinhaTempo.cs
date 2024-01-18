using Domain.Models.Abstracts;

namespace Domain.Records
{
    public class LinhaTempo
    {
        public int Numero { get; private set; }

        public IList<DateTime> Datas { get; private set; }


        public LinhaTempo(int numero, IEnumerable<LoteriaAbstract> loterias)
        {
            Numero = numero;
            Datas = new List<DateTime>();
            foreach (var l in loterias)
                Datas.Add(Convert.ToDateTime(l.Data));

            Datas = Datas.OrderBy(l => l.Date).ToList();


        }
    }
}
