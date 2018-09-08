using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngularServices;
using WebApiData;

namespace WebApiAngular.Controllers.api
{
    public class AuthorsController : ApiController
    {
        private readonly AuthorService authorService;

        public AuthorsController()
        {
            authorService = new AuthorService();
        }

        // GET: api/Authors
        public IHttpActionResult GetAuthor()
        {
            var list = authorService.AuthorAll();

            return Ok(list);
        }

        // GET: api/Authors/5
        [ResponseType(typeof(Author))]
        public IHttpActionResult GetAuthor(int id)
        {
            var author = authorService.AuthorById(id);
            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAuthor(int id, Author author)
        {
            authorService.EditAuthor(author);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Authors
        [ResponseType(typeof(Author))]
        public IHttpActionResult PostAuthor(Author author)
        {
            authorService.SaveAuthor(author);

            return StatusCode(HttpStatusCode.Created);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(Author))]
        public IHttpActionResult DeleteAuthor(int id)
        {
            authorService.DeleteAuthor(id);

            return Ok();
        }
    }
}