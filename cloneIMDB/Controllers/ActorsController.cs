using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cloneIMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private static List<Actors> actor = new List<Actors>
            {
                new Actors
                {
                    Name="Salman Khan",
                    Bio="One of the Khans",
                    DOB="12-11-1970",
                    Gender="Male",
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<Actors>>> Get()
        {
            return Ok(actor);
        }
        //[HttpGet]
        //public async Task<ActionResult<List<Actors>>> Get(string name)
        //{
        //    var act = actor.Find(m => m.Name == name);
        //    return Ok(actor);
        //}
        [HttpPost]
        public async Task<ActionResult<List<Actors>>> AddActor(Actors act)
        {
            actor.Add(act);
            return Ok(actor);
        }
    }
}
