using Domain.Enums;
using Domain.Records;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Jogo> Get()
        {
			return Enum.GetValues(typeof(eLoteria))
	            .Cast<eLoteria>()
	            .Select(v => new Jogo(v.ToString(), Regex.Replace(v.ToString(), "(\\B[A-Z])", " $1")))
	            .ToList();
        }
    }
}