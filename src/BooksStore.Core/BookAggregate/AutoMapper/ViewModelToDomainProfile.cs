using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BooksStore.Core.BookAggregate.Commands;
using BooksStore.Core.BookAggregate.ViewModel;

namespace BooksStore.Core.BookAggregate.AutoMapper;
public class ViewModelToDomainProfile : Profile
{
    public ViewModelToDomainProfile()
    {
        CreateMap<BookViewModel, CreateBookCommand>()
            .ConstructUsing(c => new CreateBookCommand(c.Title, c.ImageUrl, c.Price));
    }

}
