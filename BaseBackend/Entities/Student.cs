#nullable disable

using BaseBackend.Enums;

namespace BaseBackend.Entities;

//Container For Methods and Property
//Template for object
//Custom Data Type
public class Student : User
{
    #region Constructors
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

    #endregion

    #region Properties
    public Gender Gender { get; set; }

    #endregion

    #region Methods
    public void ChangeFirstName(string newFirstName) => FirstName = newFirstName;
    public void UpdateUser(string newFirstName, string newLastName)
    {
        if (!string.IsNullOrEmpty(newFirstName))
            FirstName = newFirstName;

        if (!string.IsNullOrEmpty(newLastName))
            LastName = newLastName;
    }
    private void InitialGender() => Gender = Gender.NOT_SET;
    #endregion

}
