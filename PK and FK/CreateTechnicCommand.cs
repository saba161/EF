using System;
using Project_Geolab;

public class CreateTechnicCommand
{
    private readonly string name;
    private readonly string email;
    private readonly int age;
    //private readonly string productname;
    //private readonly int quantity;

    public CreateTechnicCommand(string name, string email, int age)
    {
        this.name = name;
        this.email = email;
        this.age = age;

        //this.productname = productname;
        //this.quantity = quantity;
    }

    public void Execute()
    {
        using(Technic context = new Technic())
        {
            Customer customer = new Customer() 
            {
                Name = this.name,
                Email = this.email,
                Age = this.age
            };
            //Order order = new Order() 
            //{
             //   ProductName = this.productname,
             //   Quantity = this.quantity,
             //   Customer = customer
            //};
            context.Customers.Add(customer);
            //context.Orders.Add(order);
            context.SaveChanges();
        }
        Console.WriteLine("Record is Created");
    }
}