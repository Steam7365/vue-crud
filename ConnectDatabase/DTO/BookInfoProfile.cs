using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookInfoProfile : Profile
    {
        public BookInfoProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<BookType, BookTypeDto>();

        }
    }
}
