using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatControllerOld : ControllerBase
    {
        
        private readonly TshirtContext _context;

        public TShirtController(TshirtContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TShirtOrder>> GetById(long id)
        {
            var product = await _context.TShirtOrders.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

               return product;
        }
       
        [HttpPost]
        public async Task<ActionResult<TShirtOrder>> Post([FromBody]TShirtOrder shirtOrder)
        {

            _context.TShirtOrders.Add(shirtOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = shirtOrder.Id }, shirtOrder);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {


        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {


        }
    }
} 
