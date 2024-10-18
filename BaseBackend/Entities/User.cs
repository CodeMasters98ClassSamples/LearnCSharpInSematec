#nullable disable

using BaseBackend.Entities.Interfaces;
using BaseBackend.Enums;

namespace BaseBackend.Entities;

public class User : IBaseEntity, ICreateableEntity, IDeleteableEntity
{
    public User()
    {
        InitialGender();
    }

    public int Id { get; set; }
    public string NationalCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string LastDocument { get; set; }
    public Gender Gender { get; set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int DeletedByUserId { get; set; }

    private void InitialGender() => Gender = Gender.NOT_SET;
}
