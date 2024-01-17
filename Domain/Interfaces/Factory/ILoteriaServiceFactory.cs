using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Factory
{
    public interface ILoteriaServiceFactory<out T, out TInterface> where T : LoteriaAbstract where TInterface : ILoteriaService<T>
    {
        TInterface FactoryService(eLoteria loteria);
    }
}
