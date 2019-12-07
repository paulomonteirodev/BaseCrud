using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using WebApiData;

namespace WebApiAngularServices
{
    public class BookService
    {
        public List<BookViewModel> BookAll()
        {
            var dto = new List<BookViewModel>();

            using (var db = new Entities())
            {
                dto = db.Book.Select(x => new BookViewModel
                       {
                           AuthorId = x.AuthorId,
                           Id = x.Id,
                           Name = x.Name,
                           AuthorName = x.Author.Name
                       }).ToList();
            }

            return dto;
        }

        public BookViewModel BookById(int id)
        {
            var dto = new BookViewModel();

            using (var db = new Entities())
            {
                var book = db.Book.Find(id);

                dto.Id = book.Id;
                dto.AuthorId = book.AuthorId;
                dto.Name = book.Name;
                dto.AuthorName = book.Author.Name;
            }

            return dto;
        }

        public void EditBook(Book book)
        {
            using (var db = new Entities())
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void SaveBook(Book book)
        {
            using (var db = new Entities())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            using (var db = new Entities())
            {
                var book = db.Book.Find(id);

                if (book != null)
                {
                    db.Book.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }

    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}