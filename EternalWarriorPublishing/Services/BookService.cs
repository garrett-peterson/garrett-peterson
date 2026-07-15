using EternalWarriorPublishing.Models;

namespace EternalWarriorPublishing.Services;

public class BookService
{
    private readonly List<Book> books = new()
    {
        new Book
        {
            Title = "The Last Shieldbearer",
            Slug = "the-last-shieldbearer",
            Genre = "Epic Fantasy",
            Description = "A fallen knight must defend a mountain city from an army no one believes is real.",
            Initials = "LS",
            IsFeatured = true
        },
        new Book
        {
            Title = "Ashes of the Crown",
            Slug = "ashes-of-the-crown",
            Genre = "Heroic Adventure",
            Description = "A princess, a thief, and a disgraced captain race to recover a crown lost in dragonfire.",
            Initials = "AC",
            IsFeatured = true
        },
        new Book
        {
            Title = "The Lantern Road",
            Slug = "the-lantern-road",
            Genre = "Historical Fantasy",
            Description = "A young scribe follows a trail of forbidden lanterns into a kingdom erased from history.",
            Initials = "LR",
            IsFeatured = true
        },
        new Book
        {
            Title = "The Iron Saint",
            Slug = "the-iron-saint",
            Genre = "Epic Fantasy",
            Description = "A warrior monk must protect a sacred city from an empire built on forbidden magic.",
            Initials = "IS",
            IsFeatured = false
        },
        new Book
        {
            Title = "Swords Beneath the Sun",
            Slug = "swords-beneath-the-sun",
            Genre = "Heroic Adventure",
            Description = "Two rivals cross a burning desert to recover a weapon that should have stayed buried.",
            Initials = "SS",
            IsFeatured = false
        }
    };

    public List<Book> GetAllBooks()
    {
        return books;
    }

    public List<Book> GetFeaturedBooks()
    {
        return books.Where(book => book.IsFeatured).ToList();
    }

    public Book? GetBookBySlug(string slug)
    {
        return books.FirstOrDefault(book => book.Slug == slug);
    }
}