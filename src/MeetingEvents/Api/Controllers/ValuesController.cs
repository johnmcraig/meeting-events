using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers 
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
        public ValuesController() 
        { 

        }

        // GET api/values
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings() 
        {
            return new List<string> { };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost("")]
        public void Poststring(string value) 
        { 

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value) 
        { 

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        { 

        }
    }
}