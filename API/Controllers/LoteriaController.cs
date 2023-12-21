using Domain.Documents;
using Domain.Enums;
using Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoteriaController : ControllerBase
    {
        private readonly IMegaSenaRepository<MegaSenaDocument> _repo;

        public LoteriaController(IMegaSenaRepository<MegaSenaDocument> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("{loteria}")]
        public async Task<IActionResult> GetAsync(eLoteria loteria)
        {
            var teste = await _repo.GetLastAsync();
            return Ok(teste);
        }

        [HttpGet]
        [Route("{loteria}/ultima")]
        public IActionResult GetLastAsync(eLoteria loteria)
        {
            return Ok();
        }
    }
}