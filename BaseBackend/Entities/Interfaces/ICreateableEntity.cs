namespace BaseBackend.Entities.Interfaces;

public interface ICreateableEntity
{
    public DateTime CreatedAt { get; set; }
    public int CreatedByUserId { get; set; }
}
