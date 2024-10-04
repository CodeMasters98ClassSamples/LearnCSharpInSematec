namespace LearnCSharpInSematec.Models;

public class Master : User
{
    public int Id { get; set; }
  
    //زمان شروع همکاری با استاد
    public DateTime CreateAt { get; set; }
}
