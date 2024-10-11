namespace BaseBackend.Entities.Interfaces;

public interface IDeleteableEntity
{
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    public int DeletedByUserId { get; set; }
}
