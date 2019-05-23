using System;
using System.Linq;
using Project_Geolab;

public class ExistingCustomer 
{
    private readonly string email;
    private readonly string productname;
    private readonly int quantity;

    public ExistingCustomer(string email, string productname, int quantity)
    {

        this.email = email;

        this.productname = productname;
        this.quantity = quantity;
    }

    public void Existing()
    {
        using(Technic context = new Technic())
        {
            var ExistingEmail = context.Orders.Where(o => o.Customer.Email == this.email);
            Order order = new Order()
            {
                ProductName = this.productname,
                Quantity = this.quantity
            };
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}