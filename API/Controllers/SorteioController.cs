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
    public class SorteioController : ControllerBase
    {
        private readonly ISorteioModelService<SorteioAbstract> _service;

        public SorteioController(ISorteioModelService<SorteioAbstract> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{loteria}")]
        public async Task<IEnumerable<SorteioAbstract>> GetAsync(eLoteria loteria)
        {
           return await _service.GetAsync(loteria);
        }

        [HttpGet]
        [Route("{loteria}/ultimos")]
        public async Task<IEnumerable<SorteioAbstract>> GetLastAsync(eLoteria loteria, [FromHeader] int ultimos = 3)
        {
            return await _service.GetLastAsync(loteria, ultimos);
        }

        [HttpGet]
        [Route("ProbabilidadeExperimental/{loteria}")]
        public async Task<ProbabilidadeExperimental> EstimativaAsync(eLoteria loteria)
        {
            return await _service.GerarEstivaAsync(loteria);
        }

        [HttpGet]
        [Route("LinhaDoTempo/{numero}")]
        public async Task<IEnumerable<LinhaDoTempo>> EstimativaAsync(int numero)
        {
            return await _service.LinhaTempoAsync(numero);
        }

        [HttpGet]
        [Route("LinhaDoTempo/{loteria}/{numero}")]
        public async Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, int numero)
        {
            return await _service.LinhaTempoAsync(loteria, numero);
        }
    }
}