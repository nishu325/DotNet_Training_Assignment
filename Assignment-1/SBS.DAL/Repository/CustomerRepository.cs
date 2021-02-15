using SBS.DAL.Database;
using SBS.DAL.Repository.Interface;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SBS.DAL.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DotNetAssignmentEntities db;
        public CustomerRepository()
        {
            db = new DotNetAssignmentEntities();
        }

        //For booking service request with customer id.
        public bool Book(Vehicle model, int id)
        {
            if(model!=null)
            {
                Mapper.CreateMap<Vehicles,Vehicle>().ForMember(x=>x.CustomerId,m=>m.UseValue(id));
                Vehicles vehicles = Mapper.Map<Vehicles>(model);
                db.Vehicles.Add(vehicles);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        //Display all previous customer appointment booking details.
        public List<Vehicle> GetData(int id)
        {
            var data = db.Vehicles.Where(m=>m.CustomerId==id).ToList() ;
            List<Vehicle> list = new List<Vehicle>();
            if(data!=null)
            {
                Mapper.CreateMap<Vehicles,Vehicle>();
                foreach(var item in  data)
                {
                    Vehicle vehicle = Mapper.Map<Vehicle>(item);
                    list.Add(vehicle);
                }
            }          
            return list.ToList();         
        }

        //For customer login with email & password.
        public int Login(string email, string password)
        {
            var data = db.Customers.FirstOrDefault(m=>m.Email==email && m.Password==password);
            if (data!=null)
                return data.Id;
            return 0;
        }

        //Register new customer with all details,
        public bool Register(Customer model)
        {
            if(model!=null)
            {
                var data = db.Customers.Any(m => m.Email == model.Email); //Check email id is already registered or not. 
                if (!data)
                {
                    Mapper.CreateMap<Customer, Customers>();
                    var result = Mapper.Map<Customer, Customers>(model);
                    db.Customers.Add(result);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
