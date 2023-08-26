using Pustok.Database.Models;

namespace Pustok.Database.Repositories;

public class BookRepository
{
    private static readonly List<Book> _books = new List<Book>();

    static BookRepository()
    {
        _books.Add(new Book("The adventure of pirgim", "This is description", "Social media master", 200, DateTime.Now));
        _books.Add(new Book("Knyaz where are you?", "This is description", "Ilham", 300, DateTime.Now));
        _books.Add(new Book("Detective", "This is Detective", "Detective author", 150, DateTime.Now));
        _books.Add(new Book("The adventure of heyder?", "This is description", "Heyder", 300, DateTime.Now));
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public void Insert(Book book)
    {
        _books.Add(book);
    }

    public Book GetById(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public void RemoveById(int id)
    {
        _books.RemoveAll(b => b.Id == id);
    }
}
