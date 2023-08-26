namespace Pustok.Database.Models;

public class Holiday
{
    public Holiday(int ıd, string name, string title)
    {
        Id = ıd;
        Name = name;
        Title = title;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
}
