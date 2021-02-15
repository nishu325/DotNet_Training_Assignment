using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository.Interface
{
    public interface ICustomerRepository
    {
        int Login(string email, string password);
        bool Register(Customer model);
        List<Vehicle> GetData(int id);
        bool Book(Vehicle model, int id);
    }
}
