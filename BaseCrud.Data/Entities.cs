using System.Data.Entity;

namespace WebApiData
{
    public class Entities : DbContext
    {
        public Entities()
            :base("Default")
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
