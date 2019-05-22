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
            var findedRecords = context.Customers.Where(o => o.Email == this.email).FirstOrDefault();
            if(findedRecords != null)
            {
                foreach(var item in findedRecords.Orders)
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

