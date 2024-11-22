using BaseBackend.Entities;

namespace BaseBackend.Businesses.Interfaces;

public interface IBaseBusiness<T> where T : class
{
    public List<T> GetAll();
    public bool Add(T item);
    public bool Delete(int id);
    public bool Update(T item);
}
