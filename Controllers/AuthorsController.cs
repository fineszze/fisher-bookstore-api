using Fisher.Bookstore.Models;
using Fisher.Bookstore.Services;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private IAuthorsRepository authorsRepository;
        public AuthorsController(IAuthorsRepository repository)
        {
            authorsRepository = repository;
        }

        [HttpGet("{authorsId}")]
        public IActionResult Get(int authorsId)
        {
            if (!authorsRepository.AuthorExists(authorsId))
            {
                return NotFound();
            }
            return Ok(authorsRepository.GetAuthor(authorsId));
        }

        
        [HttpPost]
        public IActionResult Post([FromBody]Author authors)
        {
            var authorsId = authorsRepository.AddAuthor(authors);
            return Created($"https://localhost:5001/api/authors/{authorsId}", authors);
        }

        [HttpPut("{authorsId}")]
        public IActionResult Put(int authorsId, [FromBody] Author authors)
        {
            if (authorsId != authors.Id)
            {
                return BadRequest();
            }

            if (!authorsRepository.AuthorExists(authorsId))
            {
                return NotFound();
            }
            authorsRepository.UpdateAuthor(authors);
            return Ok(authors);
        }

        [HttpDelete("{authorsId}")]
        public IActionResult Delete(int authorsId)
        {
            if (!authorsRepository.AuthorExists(authorsId))
            {
                return NotFound();
            }

            authorsRepository.DeleteAuthor(authorsId);
            return Ok();
        }



    }
}