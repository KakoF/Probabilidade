using Domain.Enums;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
using Domain.Records;
using Domain.Records.Requests;
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
        [Route("ProbabilidadeCalculada/{loteria}")]
        public async Task<ProbabilidadeCalculada> EstimativaAsync(eLoteria loteria)
        {
            return await _service.GerarEstivaAsync(loteria);
        }

        [HttpPost]
        [Route("LinhaDoTempo")]
        public async Task<IEnumerable<LinhaDoTempo>> EstimativaAsync([FromBody] LinhaTempoRequest request)
        {
            return await _service.LinhaTempoAsync(request);
        }

        [HttpPost]
        [Route("LinhaDoTempo/{loteria}")]
        public async Task<LinhaDoTempo> LinhaTempoAsync(eLoteria loteria, [FromBody] LinhaTempoRequest request)
        {
            return await _service.LinhaTempoAsync(loteria, request);
        }
    }
}