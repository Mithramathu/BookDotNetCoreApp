using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.Entity;
namespace BookDotNetCore.DAL.Repositories
{
    public interface IBookRepository
    {
        string SaveBook(BookDetails bookDetails);
        string UpdateBook(BookDetails bookDetails);
        string DeleteBook(int bookId);
        BookDetails GetBook(int bookId);
        List<BookDetails> GetAllBooks();

    }
}
