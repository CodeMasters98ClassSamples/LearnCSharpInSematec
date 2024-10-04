namespace LearnCSharpInSematec.Models;

public class StudentCourse
{
    public Student Student { get; set; }
    public Master Master { get; set; }
    public Course Course { get; set; }

    //زمان ثبت نام دانشجو در دوره مورد نظر با استاد مربوطه در سیستم
    public DateTime CreateAt { get; set; }
}
