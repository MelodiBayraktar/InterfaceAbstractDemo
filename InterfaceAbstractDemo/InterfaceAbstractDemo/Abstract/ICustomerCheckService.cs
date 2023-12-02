using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract;

public interface ICustomerCheckService
{
    bool CheckIfRealPerson(Customer customer);
}