using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAngularServices;
using WebApiData;

namespace WebApiAngular.Controllers.api
{
    public class BooksController : ApiController
    {
        private readonly BookService bookService;

        public BooksController()
        {
            bookService = new BookService();
        }

        // GET: api/Books
        public IHttpActionResult GetBook()
        {
            var list = bookService.BookAll();

            return Ok(list);
        }

        // GET: api/Books/5
        [ResponseType(typeof(Book))]
        public IHttpActionResult GetBook(int id)
        {
            var book = bookService.BookById(id);

            return Ok(book);
        }

        // PUT: api/Books/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBook(int id, Book book)
        {
            bookService.EditBook(book);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Books
        [ResponseType(typeof(Book))]
        public IHttpActionResult PostBook(Book book)
        {
            bookService.SaveBook(book);

            return StatusCode(HttpStatusCode.Created);
        }

        // DELETE: api/Books/5
        [ResponseType(typeof(Book))]
        public IHttpActionResult DeleteBook(int id)
        {
            bookService.DeleteBook(id);

            return Ok();
        }
    }
}