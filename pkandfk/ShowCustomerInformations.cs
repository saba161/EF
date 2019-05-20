using System;
using System.Linq;
using Project_Geolab;

public class ShowCustomerInformations 
{
    private readonly string email;

    public ShowCustomerInformations(string email)
    {
        this.email = email;
    }

    public void Show()
    {
        using(Technic context = new Technic())
        {
            //var findedRecords = context.Customers.Where(r => r.Email == this.email).ToList();
            var findedRecords = context.Orders.Where(o => o.Customer.Email == this.email).ToList();
            if(findedRecords.Count() > 0)
            {
                foreach(var item in findedRecords)
                {
                    var id = item.Id;
                    Console.WriteLine($"Id: {item.Id}, ProductName: {item.ProductName}, Quantity: {item.Quantity}, PurchaseDate: {item.PurchaseDate}");
                }
            }else
            {
                Console.WriteLine("Error");
            }          
        }
    }
}

