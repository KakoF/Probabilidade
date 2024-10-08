using Domain.Enums;
using Domain.Records;
using Microsoft.AspNetCore.Mvc;
using System;
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


		[HttpGet("Random")]
		public IActionResult GetRandom()
		{
			Random random = new Random();
			int randomNumber = random.Next(0, 101);
			if (randomNumber >= 80)
				return BadRequest();

			return Ok(Enum.GetValues(typeof(eLoteria))
				.Cast<eLoteria>()
				.Select(v => new Loteria(v.ToString(), Regex.Replace(v.ToString(), "(\\B[A-Z])", " $1")))
				.ToList());
		}
	}
}