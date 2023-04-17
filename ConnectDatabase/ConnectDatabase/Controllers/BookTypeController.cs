using AutoMapper;
using Entityformwork.info;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ConnectDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTypeController : ControllerBase
    {
        private MyContext context;
        private IMapper mapper;
        public BookTypeController(MyContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<BookType>> GetBooks()
        {
            return context.BooksTypes.ToList();
        }
    }
}
