using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Domain.Records;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoteriaController : ControllerBase
    {
        private readonly ILoteriaModelService<LoteriaAbstract> _service;

        public LoteriaController(ILoteriaModelService<LoteriaAbstract> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{loteria}")]
        public async Task<IEnumerable<LoteriaAbstract>> GetAsync(eLoteria loteria)
        {
            return await _service.GetAsync(loteria);
        }

        [HttpGet]
        [Route("{loteria}/ultima")]
        public async Task<LoteriaAbstract> GetLastAsync(eLoteria loteria)
        {
            return await _service.GetLastAsync(loteria);
        }

        [HttpGet]
        [Route("Estimativa/Porcentagem/{loteria}")]
        public async Task<Estimativa> EstimativaAsync(eLoteria loteria)
        {
            return await _service.GerarEstivaAsync(loteria);
        }

        [HttpGet]
        [Route("Estimativa/Porcentagem/{loteria}/{numero}")]
        public async Task<Estimativa> EstimativaNumeroAsync(eLoteria loteria, int numero)
        {
            return await _service.GerarEstivaAsync(loteria, numero);
        }

        [HttpGet]
        [Route("Linha/Tempo/{numero}")]
        public async Task<IEnumerable<LinhaTempo>> EstimativaAsync(int numero)
        {
            return await _service.LinhaTempoAsync(numero);
        }

        [HttpGet]
        [Route("Linha/Tempo/{loteria}/{numero}")]
        public async Task<LinhaTempo> LinhaTempoAsync(eLoteria loteria, int numero)
        {
            return await _service.LinhaTempoAsync(loteria, numero);
        }


        [HttpPost]
        [Route("Analise/Jogo/{loteria}")]
        public async Task<IEnumerable<Analise>> AnaliseJogoAsync(eLoteria loteria, [FromBody] IEnumerable<int> numeros)
        {
            return await _service.AnaliseJogoAsync(loteria, numeros);
        }
    }
}