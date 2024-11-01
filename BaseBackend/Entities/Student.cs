#nullable disable

using BaseBackend.Enums;
using System.Diagnostics;

namespace BaseBackend.Entities;

//Container For Methods and Property
//Template for object
//Custom Data Type
[DebuggerDisplay("Student {Id}: {FirstName} {LastName}.")]
public class Student : User
{
    #region Constructors
    public Student() : base()
    {
        //InitialGender();
    }

    public Student(string phoneNumber, string nationalCode) :this()
    {
        PhoneNumber = phoneNumber;
        NationalCode = nationalCode;
    }

    public Student(string firstName, string lastName, string phoneNumber, string nationalCode) : this(phoneNumber,nationalCode)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    #endregion

    #region Properties
    

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
    #endregion

}
