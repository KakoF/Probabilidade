﻿using Domain.Models.Abstracts;

namespace Domain.Models
{
    public class QuinaModel : LoteriaAbstract
    {
        protected override string Nome => "Quina";
        public QuinaModel(int concurso, string data, string local, IEnumerable<string> dezenasOrdemSorteio, IEnumerable<string> dezenas, IEnumerable<string> trevos) : base(concurso, data, local, dezenasOrdemSorteio, dezenas, trevos)
        { 
        }
    }
}
