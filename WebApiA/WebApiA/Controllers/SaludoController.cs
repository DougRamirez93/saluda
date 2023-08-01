using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPi.Controllers
{
    [Route("api")]
    [ApiController]
    public class SaludoController : ControllerBase
    {
        // GET: api/<SaludoController>
        [HttpGet("saluda")]
        public string Get()
        {
            return "Hola desde mi api A";
        }

        // GET api/<SaludoController>/5
        [HttpGet("saludando/{nombre}/{mensaje}")]
        public string Get(string nombre, string mensaje)
        {
            return $"{nombre} dice: {mensaje} desde api A";
        }

        // POST api/<SaludoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SaludoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SaludoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
