﻿using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class DiaDeSorteService : SorteioService<DiaDeSorteModel, DiaDeSorteDocument>, IDiaDeSorteService
    {
        public DiaDeSorteService(IDiaDeSorteRepository repository) : base(repository)
        {
        }
    }
}
