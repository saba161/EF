using System;
using System.Linq;
using Project_Geolab;

public class ShowOrders 
{
    private readonly string email;

    public ShowOrders(string email)
    {
        this.email = email;
    }

    public void Show()
    {
        using(Technic context = new Technic())
        {
            var findedRecords = context.Customers.Where(r => r.Email == this.email);
            var findedid = context.Orders.Where(o => o.Id == o.CustomerId).ToList();

            if(findedRecords.Count() > 0)
            {
                foreach(var item in findedRecords)
                {
                    var id = item.Id;
                }
            }           
            if(findedid.Count() > 0)
            {
                foreach(var itemo in findedid)
                {
                    Console.WriteLine($"Id: {itemo.Id} Platform: {itemo.CustomerId} Title: {itemo.ProductName} Quantity: {itemo.Quantity} PurchaseDate: {itemo.PurchaseDate}");
                }
            }
        }
    }
}

