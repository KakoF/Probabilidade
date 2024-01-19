﻿using Domain.Documents;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class MegaSenaService : LoteriaService<MegaSenaModel, MegaSenaDocument>, IMegaSenaService
    {
        public MegaSenaService(IMegaSenaRepository repository) : base(repository)
        {
        }
    }
}
