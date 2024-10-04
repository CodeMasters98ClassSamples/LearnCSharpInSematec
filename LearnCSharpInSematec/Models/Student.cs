#nullable disable

using LearnCSharpInSematec.Enums;

namespace LearnCSharpInSematec.Models;

//Container For Methods and Property
//Template for object
//Custom Data Type
public class Student : User
{
    public Student()
    {
        InitialGender();
    }

    public Student(string phoneNumber, string nationalCode) : base()
    {
        PhoneNumber = phoneNumber;
        NationalCode = nationalCode;
        InitialGender();
    }

    public Student(string firstName, string lastName, string phoneNumber, string nationalCode) //: base(phoneNumber,nationalCode)
    {
        FirstName = firstName;
        LastName = lastName;
        InitialGender();
    }

    //AccessModifier DataType Name {get; set;}
    public int Id { get; set; }
   
    public Gender Gender { get; set; }

    //زمان ثبت نام دانشجو در سیستم
    public DateTime CreateAt { get; set; }

    public void ChangeFirstName(string newFirstName) => FirstName = newFirstName;

    public void UpdateUser(string newFirstName, string newLastName)
    {
        if (!string.IsNullOrEmpty(newFirstName))
            FirstName = newFirstName;

        if (!string.IsNullOrEmpty(newLastName))
            LastName = newLastName;
    }

    private void InitialGender() => Gender = Gender.NOT_SET;
}
