using BaseBackend.Entities;
using Newtonsoft.Json;

namespace BaseBackend.Businesses;

public class StudentBusinessOld
{
    public List<Student> students =  new List<Student>();

    public StudentBusinessOld()
    {
        var studentJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Students.json");
        if (File.Exists(studentJsonPath))
        {
            string studentJsonStr = File.ReadAllText(studentJsonPath);
            students = JsonConvert.DeserializeObject<List<Student>>(studentJsonStr) ?? [];
        }
    }

    public List<Student> GetStudens()
    {
        return students;
    }

    public bool AddStudent(Student student)
    {
        students.Add(student);
        return true;
    }

    public bool UpdateStudent(Student student)
    {
        var std = students.Where(x => x.Id == student.Id).FirstOrDefault();
        std.NationalCode = student.NationalCode;

        return true;
    }

    public bool DeleteStudent(int Id)
    {
        return true;
    }
}
