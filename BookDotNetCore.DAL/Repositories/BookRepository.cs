using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.Entity;
using BookDotNetCore.DAL.Data;
namespace BookDotNetCore.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookDbContext _dbContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _dbContext = bookDbContext;
        }
        public string DeleteBook(int bookId)
        {
            BookDetails book = _dbContext.bookDetails.Find(bookId);
            _dbContext.bookDetails.Remove(book);
            _dbContext.SaveChanges();
            return "Deleted";
        }

        public List<BookDetails> GetAllBooks()
        {
            return new List<BookDetails>();
        }

        public BookDetails GetBook(int bookId)
        {
            BookDetails book = _dbContext.bookDetails.Find(bookId);
            return book;
        }

        public string SaveBook(BookDetails bookDetails)
        {
            _dbContext.bookDetails.Add(bookDetails);
            _dbContext.SaveChanges();
            return "Saved";
        }

        public string UpdateBook(BookDetails bookDetails)
        {
            return "Updated";
        }
    }
}