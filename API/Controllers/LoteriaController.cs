using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoteriaController : ControllerBase
    {
        public LoteriaController()
        {
        }

        [HttpGet]
        [Route("{loteria}")]
        public IActionResult GetAsync(eLoteria loteria)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{loteria}/ultima")]
        public IActionResult GetLastAsync(eLoteria loteria)
        {
            return Ok();
        }
    }
}