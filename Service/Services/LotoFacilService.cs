﻿using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class LotoFacilService : LoteriaService<LotoFacilModel>, ILotoFacilService
    {
        public LotoFacilService(ILotoFacilRepository repository) : base(repository)
        {
        }
    }
}