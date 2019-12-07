using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebApiData;

namespace WebApiAngularServices
{
    public class AuthorService
    {
        public List<AuthorViewModel> AuthorAll()
        {
            var dto = new List<AuthorViewModel>();

            using (var db = new Entities())
            {
                dto = db.Author.Select(x => new AuthorViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }

            return dto;
        }

        public AuthorViewModel AuthorById(int id)
        {
            var dto = new AuthorViewModel();

            using (var db = new Entities())
            {
                var author = db.Author.Find(id);

                dto.Id = author.Id;
                dto.Name = author.Name;
            }

            return dto;
        }

        public void EditAuthor(Author Author)
        {
            using (var db = new Entities())
            {
                db.Entry(Author).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void SaveAuthor(Author Author)
        {
            using (var db = new Entities())
            {
                db.Author.Add(Author);
                db.SaveChanges();
            }
        }

        public void DeleteAuthor(int id)
        {
            using (var db = new Entities())
            {
                var author = db.Author.Find(id);
                if (author != null)
                {
                    db.Author.Remove(author);
                    db.SaveChanges();
                }
            }
        }
    }

    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}