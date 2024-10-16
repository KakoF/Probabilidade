﻿using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class QuinaService : SorteioService<QuinaModel, QuinaDocument>, IQuinaService
    {
        public QuinaService(IQuinaRepository repository) : base(repository)
        {
        }
    }
}
