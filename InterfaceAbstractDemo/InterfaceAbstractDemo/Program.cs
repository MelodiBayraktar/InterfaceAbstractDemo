// See https://aka.ms/new-console-template for more information

using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

class Program
{
    public static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        customerManager.Save(new Customer{DateOfBirth = new DateTime(1999,4,9),FirstName = "Melodi", LastName = "Bayraktar",NationalityId = Convert.ToInt64("12341234123")});
    }
}

