using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        [HttpGet("get-all-users")]
        public async Task<IActionResult> GetAllUsers()
        {
            List<string> people = new List<string>()
            {
                "Murad","Senan","Zabil","Result"
            };
            return Ok(people);
        }

        [HttpPost("create-person")]
        public async Task<IActionResult> CreatePerson(Person person,[FromHeader]string toke)
        {
            return Ok("New Person added");
        }

        [HttpGet]
        public async Task<IActionResult> BadRequedtResult()
        {
            return BadRequest();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string FullName { get; set; }
    }
}
