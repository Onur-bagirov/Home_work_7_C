using StoreAppProject.Models;

namespace StoreAppProject.Database;

public class StoreAppDatabase
{
    public List<Customer> Customers { get; set; }
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }
    public StoreAppDatabase()
    {
        Customers = new List<Customer>();
        Products = new List<Product>();
        Orders = new List<Order>();
    }
}