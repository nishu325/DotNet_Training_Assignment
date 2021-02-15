using SBS.BAL.Interface;
using SBS.DAL.Repository.Interface;
using SBS.Models;
using System.Collections.Generic;

namespace SBS.BAL
{
    public class CustomerManager : ICustomerManager
    {
        public readonly ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public bool Book(Vehicle model, int id)
        {
            return _customerRepository.Book(model, id);
        }

        public List<Vehicle> GetData(int id)
        {
            return _customerRepository.GetData(id);
        }

        public int Login(string email, string password)
        {
            return _customerRepository.Login(email, password);
        }

        public bool Register(Customer model)
        {
            return _customerRepository.Register(model);
        }
    }
}
