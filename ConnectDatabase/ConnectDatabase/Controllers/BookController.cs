using AutoMapper;
using Entityformwork.info;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
namespace ConnectDatabase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private MyContext context;
        private IMapper mapper;
        public BookController(MyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return context.Books.ToList();
        }

        [HttpGet]
        public ActionResult<Book> GetByIdBooks(int id)
        {
            return context.Books.SingleOrDefault(x => x.Id == id);
        }

        [HttpDelete]
        public ActionResult<int> DeleteByIdBooks(int id)
        {
            Book book = context.Books.SingleOrDefault(x => x.Id == id);
            context.Books.Remove(book);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public ActionResult<Book> PostAddBook(BookDto book)
        {
            Book book1 = mapper.Map<Book>(book);
            context.Books.Add(book1);
            context.SaveChanges();
            return book1;
        }

        [HttpPut]
        public ActionResult<Book> PutUpdateBook(BookDto book)
        {
            Book isBook = context.Books.AsNoTracking().SingleOrDefault(x => x.Id == book.Id);
            if (isBook == null)
            {
                return NotFound();
            }
            Book newBook = mapper.Map<Book>(book);
            context.Books.Update(newBook);
            context.SaveChanges();
            return newBook;
        }
    }
}
