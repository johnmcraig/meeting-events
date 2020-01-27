using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Api.Controllers 
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
        private readonly DataDbContext _dbContext;
        public ValuesController(DataDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> GetAll() 
        {
            var values = await _dbContext.Values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> GetSingle(int id)
        {
            var value = await _dbContext.Values.FindAsync(id);
            return Ok(value);
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