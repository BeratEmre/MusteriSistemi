using MusteriSistemi.Concrete;
using MusteriSistemi.Message;
using System;

namespace MusteriSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager(new Messages(), new CustomerValidationManager(new Messages()));

            customer.Add( new Customer { 
            Id=1,
            Name="Berat",
            LastName="Bayraktar"
            });
            Console.ReadKey();
        }
    }
}
