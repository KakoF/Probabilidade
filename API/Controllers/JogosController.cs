using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogosController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
			return Enum.GetValues(typeof(eLoteria))
	            .Cast<eLoteria>()
	            .Select(v => v.ToString())
	            .ToList(); ;
        }
    }
}