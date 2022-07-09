using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cloneIMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private static List<Producers> producer = new List<Producers>
            {
                new Producers
                {
                    Name="Salman Khan",
                    Bio="One of the Khans",
                    DOB="12-11-1970",
                    Gender="Male",
                    Company="Khan Enterprises"
                }               
            };
        [HttpGet]
        public async Task<ActionResult<List<Producers>>> Get()
        {
            return Ok(producer);
        }

        [HttpPost]
        public async Task<ActionResult<List<Producers>>> AddProducer(Producers prod)
        {
            producer.Add(prod);
            return Ok(producer);
        }
    }
    
}
