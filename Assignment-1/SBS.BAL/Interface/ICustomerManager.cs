using SBS.Models;
using System.Collections.Generic;

namespace SBS.BAL.Interface
{
    public interface ICustomerManager
    {
        int Login(string email, string password);
        bool Register(Customer model);
        List<Vehicle> GetData(int id);
        bool Book(Vehicle model, int id);
    }
}
