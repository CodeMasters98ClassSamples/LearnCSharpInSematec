#nullable disable

namespace LearnCSharpInSematec.Models;

public class Course
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Description { get; set; }

    //زمان تعریف دوره
    public DateTime CreateAt { get; set; }
}
