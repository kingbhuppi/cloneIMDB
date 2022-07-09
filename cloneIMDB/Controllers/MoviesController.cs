using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cloneIMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movies> movies = new List<Movies>
            {
                new Movies
                {
                    Id = 1,
                    Name="Sultan",
                    Producer="Salman Khan",
                    ReleaseDate="2020-1-1",
                    Actor={"1","2","3"}
                },
                new Movies
                {
                    Id=2,
                    Name="Sooryavanshi",
                    Producer="Akshay Kumar",
                    ReleaseDate="2016-1-1",
                    Actor={"Salman", "Rocky", "Shahrukh"}
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<Movies>>> Get()
        {
            return Ok(movies);  
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Movies>>> Get(int id)
        {
            var movie = movies.Find(m => m.Id == id);
            return Ok(movie);
        }
        [HttpPost]
        public async Task<ActionResult<List<Movies>>> AddMovie(Movies mov)
        {
            movies.Add(mov);
            return Ok(movies);
        }
        [HttpPut]
        public async Task<ActionResult<List<Movies>>> UpdateMovie(Movies request)
        {
            var movie = movies.Find(m => m.Id == request.Id);
            if(movie== null)
                return BadRequest("Movie not found");
            movie.ReleaseDate = request.ReleaseDate;
            movie.Name = request.Name;
            movie.Producer = request.Producer;
            return Ok(movies);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Movies>>> Delete(int id)
        {
            var movie = movies.Find(m => m.Id == id);
            if (movie == null)
                return BadRequest("Movie not found");
            movies.Remove(movie);
            return Ok(movies);
        }

    }
}
