using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Domain.Models.Abstracts;
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
    }
}