using Domain.Enums;
using Domain.Records;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoteriaController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Loteria> Get()
        {
			return Enum.GetValues(typeof(eLoteria))
	            .Cast<eLoteria>()
	            .Select(v => new Loteria(v.ToString(), Regex.Replace(v.ToString(), "(\\B[A-Z])", " $1")))
	            .ToList();
        }
    }
}