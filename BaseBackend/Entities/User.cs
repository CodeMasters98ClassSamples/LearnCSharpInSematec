#nullable disable

using BaseBackend.Entities.Interfaces;

namespace BaseBackend.Entities;

public class User : IBaseEntity, ICreateableEntity, IDeleteableEntity
{
    public int Id { get; set; }
    public string NationalCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string LastDocument { get; set; }
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
}
