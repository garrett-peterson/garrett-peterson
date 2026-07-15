namespace EternalWarriorPublishing.Models;

public class Book
{
    public string Title { get; set; } = "";
    public string Slug { get; set; } = "";
    public string Genre { get; set; } = "";
    public string Description { get; set; } = "";
    public string Initials { get; set; } = "";
    public bool IsFeatured { get; set; }
}