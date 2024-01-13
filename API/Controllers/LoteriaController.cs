using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoteriaController : ControllerBase
    {
        private readonly ILoteriaService<LoteriaDocument> _service;

        public LoteriaController(ILoteriaService<LoteriaDocument> service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{loteria}")]
        public async Task<IEnumerable<LoteriaDocument>> GetAsync(eLoteria loteria)
        {
           return await _service.GetAsync(loteria);
        }

        [HttpGet]
        [Route("{loteria}/ultima")]
        public async Task<LoteriaDocument> GetLastAsync(eLoteria loteria)
        {
            return await _service.GetLastAsync(loteria);
        }
    }
}