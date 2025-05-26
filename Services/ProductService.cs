
using StoreAppProject.Database;
using StoreAppProject.Models;

namespace StoreAppProject.Services;

public class ProductService : BaseService<Product>
{
    public ProductService(StoreAppDatabase database) : base(database)
    {
    }

    public override void Add(Product item)
    {
        _database.Products.Add(item);
    }

    public override List<Product> GetAll()
    {
        return _database.Products;
    }

    public override Product GetById(int id)
    {
        return _database.Products.FirstOrDefault(p => p.Id == id);
    }

    public override void Remove(Product item)
    {
        var productToRemove = GetById(item.Id);
        if (productToRemove != null)
        {
            _database.Products.Remove(productToRemove);
        }
    }
}