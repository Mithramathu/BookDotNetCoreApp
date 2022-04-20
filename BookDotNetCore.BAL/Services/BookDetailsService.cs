using BookDotNetCore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.Entity;
namespace BookDotNetCore.BAL.Services
{
    public class BookDetailsService
    {
        
        private IBookRepository _bookRepository;

        public BookDetailsService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public string SaveBook(BookDetails bookDetails)
        {
            return _bookRepository.SaveBook(bookDetails);
        }
    }
}
