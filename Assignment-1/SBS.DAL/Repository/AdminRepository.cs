using SBS.DAL.Database;
using SBS.DAL.Repository.Interface;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Web;
using System.Data.Entity;

namespace SBS.DAL.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DotNetAssignmentEntities db;
        public AdminRepository()
        {
            db = new DotNetAssignmentEntities();
        }

        //For create new Dealer with its all details.
        public bool CreateDealer(Dealer model)
        {
            if (model != null)
            {
                var data = db.Dealers.Any(m => m.Code == model.Code); //Check dealer is available or not with this dealer code.
                if (!data)
                {
                    Mapper.CreateMap<Dealer, Dealers>();
                    Dealers dealers = Mapper.Map<Dealers>(model);
                    db.Dealers.Add(dealers);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //For create new Mechanic with its all details.
        public bool CreateMechanic(Mechanic model)
        {
            if (model != null)
            {
                var data = db.Mechanics.Any(m => m.Code == model.Code); //Check mechanic is available or not with this mechanic code.
                if (!data)
                {
                    Mapper.CreateMap<Mechanic, Mechanics>();
                    Mechanics mechanics = Mapper.Map<Mechanics>(model);
                    db.Mechanics.Add(mechanics);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //For create new service with its all details.
        public bool CreateService(Service model)
        {
            if (model != null)
            {
                var data = db.Services.Any(m => m.Code == model.Code); //Check service is available or not with this service code.
                if (!data)
                {
                    Mapper.CreateMap<Service, Services>();
                    Services service = Mapper.Map<Services>(model);
                    db.Services.Add(service);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Get the list of dealer available in database.
        public List<Dealer> GetDealerList()
        {
            var data = db.Dealers.ToList();
            List<Dealer> list = new List<Dealer>();
            Mapper.CreateMap<Dealers, Dealer>();
            foreach (var item in data)
            {
                Dealer dealer = Mapper.Map<Dealer>(item);
                list.Add(dealer);
            }
            return list.ToList();
        }

        //Get the list of mechanic available in database.
        public List<Mechanic> GetMechanicData()
        {
            var data = db.Mechanics.ToList();
            List<Mechanic> list = new List<Mechanic>();
            Mapper.CreateMap<Mechanics, Mechanic>();
            foreach (var item in data)
            {
                Mechanic mechanic = Mapper.Map<Mechanic>(item);
                list.Add(mechanic);
            }
            return list.ToList();
        }

        //Update vehicle booking details.
        public Vehicle UpdateOneVehicleData(int id)
        {
            Vehicles vehicle = db.Vehicles.Find(id);
            Mapper.CreateMap<Vehicles, Vehicle>();
            var data = Mapper.Map<Vehicles, Vehicle>(vehicle);
            return data;
        }

        //Get the list of services available in database.
        public List<Service> GetServiceList()
        {
            var data = db.Services.ToList();
            List<Service> list = new List<Service>();
            Mapper.CreateMap<Services, Service>();
            foreach (var item in data)
            {
                Service service = Mapper.Map<Service>(item);
                list.Add(service);
            }
            return list.ToList();
        }

        //Get the list of vehicle data from database.
        public List<Vehicle> GetVehicleData()
        {
            var data = db.Vehicles.ToList();
            List<Vehicle> list = new List<Vehicle>();
            Mapper.CreateMap<Vehicles, Vehicle>();
            foreach (var item in data)
            {
                Vehicle vehicle = Mapper.Map<Vehicle>(item);
                list.Add(vehicle);
            }
            return list.ToList();
        }

        //Save booking details of particular vehicle.
        public bool SaveBooking(Vehicle model, int id)
        {
            if (model != null)
            {
                var entity = db.Vehicles.Find(id);
                if (entity != null)
                {
                    entity.DealerId = model.DealerId;
                    entity.ServiceId = model.ServiceId;
                    entity.MechanicId = model.MechanicId;
                    entity.BookingStatus = true;
                    entity.BookingConfirmDate = model.BookingConfirmDate;
                    entity.DeliveryDate = model.DeliveryDate;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        //Get the booking details of particlar vehicle.
        public Vehicle GetVehicleBookDetail(int id)
        {
            var data = db.Vehicles.Find(id);
            Mapper.CreateMap<Vehicles, Vehicle>();
            Vehicle result = Mapper.Map<Vehicle>(data);
            result.DealerName = data.Dealers.Name;
            result.MechanicName = data.Mechanics.Name;
            result.ServiceName = data.Services.Name;
            result.ServicePrice = data.Services.Price;
            result.ServiceTime = data.Services.Time;
            return result;
        }

    }
}
