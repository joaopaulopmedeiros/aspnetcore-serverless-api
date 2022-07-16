using Microsoft.AspNetCore.Mvc;

namespace Movies.Api.Controllers;

[Route("[controller]")]
public class MoviesController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Movie 1", "Movie 2" };
    }
}