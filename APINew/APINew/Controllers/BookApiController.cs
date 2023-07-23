using APINew.Data;
using APINew.Model;
using APINew.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace APINew.Controllers
{
    [Route("api/BookApi")]
    [ApiController]
    public class BookApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<BookDto> GetBooks()
        {
                return BookStore.bookList;
        }
        [HttpGet ("ID")]

        public BookDto GetBooks (int id)
        {
            return BookStore.bookList.FirstOrDefault(w => w.ID == id);
        }
        [HttpDelete]
        public ActionResult <Book> DeleteBooK (int id)
        {

            if (id == 0) {
            return BadRequest ();
            }
            var book = BookStore.bookList.FirstOrDefault(a=>a.ID == id);

            if (book == null)
            {
                return NotFound ();
            }
            BookStore.bookList.Remove(book);
            return Ok ();

        }
    }
    }

