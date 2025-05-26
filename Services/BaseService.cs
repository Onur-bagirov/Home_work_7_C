using StoreAppProject.Database;
using StoreAppProject.Models;

namespace StoreAppProject.Services;

public abstract class BaseService<T> where T : BaseModel
{
    protected StoreAppDatabase _database;
    public BaseService(StoreAppDatabase database)
    {
        _database = database;
    }
    public abstract void Add(T item);
    public abstract void Remove(T item);
    public abstract T GetById(int id);
    public abstract List<T> GetAll();
}