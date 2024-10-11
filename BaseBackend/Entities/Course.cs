#nullable disable

using BaseBackend.Entities.Interfaces;

namespace BaseBackend.Entities;

public class Course : IBaseEntity, ICreateableEntity, IDeleteableEntity
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int DeletedByUserId { get; set; }
}
