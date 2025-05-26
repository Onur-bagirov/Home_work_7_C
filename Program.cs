using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services;

StoreAppDatabase database = new StoreAppDatabase();
ProductService productService = new ProductService(database);

bool t = true;

while (t)
{
    Console.WriteLine("\n\n\t\t - - - Welcome - - - \n\n");
    Console.WriteLine("Add Product       : 1");
    Console.WriteLine("All Products      : 2");
    Console.WriteLine("Get Product by ID : 3");
    Console.WriteLine("Remove Product    : 4");
    Console.WriteLine("Get Order By ID   : 5");
    Console.WriteLine("All Orders        : 6");
    Console.WriteLine("Remove Order      : 7");
    Console.WriteLine("AddCustomer       : 8");
    Console.WriteLine("GetCustomerById   : 9");
    Console.WriteLine("All Customers     : 10");
    Console.WriteLine("Exit              : 11");

    Console.Write("\n\n Enter choice : ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.Clear();

            Console.Write("\n\nEnter Product Name : ");
            string name = Console.ReadLine();

            Console.Write("\nEnter Product Description : ");
            string description = Console.ReadLine();

            Console.Write("\nEnter Product Price : ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("\nEnter Product Quantity : ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("\n Enter id : ");
            int ID_ = int.Parse(Console.ReadLine());


            productService.Add(new Product {Id = ID_, Name = name, Price = price, Description = description });

            Console.Write("\n\nProduct added successfully !");
            Thread.Sleep(2000);

            Console.Clear();
            break;

        case 2:
            Console.Clear();
            List<Product> products = productService.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine(item);

            }
                Thread.Sleep(4000);  
                Console.Clear();
            break;

        case 3:
            Console.Clear();

            Console.Write("\n\n Enter id : ");
            int nameId = Convert.ToInt32(Console.ReadLine());

            Product product_ = productService.GetById(nameId);

            if(product_ != null)
            {
                Console.Write($"\n\t\t - - - Found Producs - - -  \n{product_}");
                Console.Write("\n\n Product was removed !");
            }

            else
            {
                Console.WriteLine("Product not found !");
            }
            Thread.Sleep(4000);

            Console.Clear();
            break;

        case 4:
            Console.Clear();

            Console.Write("\n\n Enter id : ");
            int removeId = Convert.ToInt32(Console.ReadLine());

            Product RemoveProduct = productService.GetById(removeId);

            if(RemoveProduct != null)
            {
                productService.Remove(RemoveProduct);
            }

            else
            {
                Console.WriteLine("Product not found !");
            }
            Thread.Sleep(4000);

            Console.Clear();
            break;

        case 5:
            Console.Clear();

            Console.Write("\nEnter id : ");
            int orderId = int.Parse(Console.ReadLine());
            Order order = database.Orders.FirstOrDefault(i => i.Id == orderId);

            if (order != null)
            {
                Console.Write(order);
            }

            else
            {
                Console.Write("\nOrder not found !");
            }

            Thread.Sleep(4000);

            Console.Clear();
            break;

        case 6:
            Console.Clear();
            List<Order> orders = database.Orders;

            foreach(var order_ in orders)
            {
                Console.Write("\n\n\t\t - - - Orders - - - \n\n");
                Console.Write(order_);
            }

            Thread.Sleep(4000);

            Console.Clear();

            break;

        case 7:
            Console.Clear();
            Console.Write("\n\n Enter id : ");
            int RemoveOrder = int.Parse(Console.ReadLine());

            Order OrderRemove = database.Orders.FirstOrDefault(_id => _id.Id == RemoveOrder);


            if (OrderRemove != null)
            {
                database.Orders.Remove(OrderRemove);
                Console.Write("\n\nOrder removed successfully !");
            }

            else
            {
                Console.WriteLine("Product not found !");
            }
            Thread.Sleep(4000);

            Console.Clear();

            break;

        case 8:
            Console.Clear();

            Console.Write("\n\nEnter name : ");
            string name_ = Console.ReadLine();

            Console.Write("\n\nEnter surname : ");
            string surname_ = Console.ReadLine();

            Console.Write("\n\nEnter gender : ");
            string gender_ = Console.ReadLine();

            Customer customers = new Customer
            {
                Name = name_,
                Surname = surname_
            };
            database.Customers.Add(customers);
            Console.Write("\n\n Customer added successfully !");

            Thread.Sleep(4000);
            Console.Clear();
            break;

        case 9:
            Console.Clear();

            Console.Write("\n\n Enter id : ");
            int CustomerId = int.Parse(Console.ReadLine());

            Customer customer_ = database.Customers.FirstOrDefault(_id_ => _id_.Id == CustomerId);

            if(customer_ != null)
            {
                Console.Write(customer_);
            }

            else
            {
                Console.Write("\n\nProduct not found !");
            }
            Thread.Sleep(4000);

            Console.Clear();
            break;

        case 10:
            Console.Clear();

            List<Customer> _customer_ = database.Customers;
            foreach (var c in _customer_)
            {
                Console.Write(c);
            }
            Thread.Sleep(4000);

            Console.Clear();
            break;
        case 11:
            Console.Clear();
            t = false;
            Console.Write("\n\nExit program !");
            break;

        default:
            Console.Write("\n\nError !");
            break;
    }
}
