using BaseBackend.Entities.Interfaces;

namespace BaseBackend.Entities;

public class StudentCourse : IBaseEntity
{
    public int Id { get; set; }
    public Student Student { get; set; }
    public Master Master { get; set; }
    public Course Course { get; set; }
}
