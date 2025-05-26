namespace StoreAppProject.Models;

public class Product : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} - Name : {Name} - Description  : {Description} - Price : {Price}";
    }
}