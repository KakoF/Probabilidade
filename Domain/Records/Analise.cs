namespace Domain.Records
{
    public class Analise
    {
      
        public int Numero { get; set; }
        public int Sorteios { get; set; }
        public int TotalSorteios { get; set; }
        public decimal EstimativaPorcentagem { get; set; }
        public LinhaTempo LinhaTempo { get; set; }
       


        public Analise(int numero, int sorteios, int totalSorteios, LinhaTempo linhaTempo, decimal estimativaPorcentagem)
        {
            Numero = numero;
            Sorteios = sorteios;
            TotalSorteios = totalSorteios;
            LinhaTempo = linhaTempo;
            EstimativaPorcentagem = estimativaPorcentagem;
            
        }
    }
}
