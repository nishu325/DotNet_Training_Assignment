using SBS.BAL.Interface;
using SBS.DAL.Repository.Interface;
using SBS.Models;
using System.Collections.Generic;

namespace SBS.BAL
{
    public class AdminManager : IAdminManager
    {
        private readonly IAdminRepository _adminRepository;
        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public List<Dealer> GetDealerList()
        {
            return _adminRepository.GetDealerList();
        }

        public bool CreateDealer(Dealer model)
        {
            return _adminRepository.CreateDealer(model);
        }

        public bool CreateMechanic(Mechanic model)
        {
            return _adminRepository.CreateMechanic(model);
        }

        public List<Mechanic> GetMechanicData()
        {
            return _adminRepository.GetMechanicData();
        }

        public bool CreateService(Service model)
        {
            return _adminRepository.CreateService(model);
        }
        public List<Vehicle> GetVehicleData()
        {
            return _adminRepository.GetVehicleData();
        }

        public Vehicle UpdateOneVehicleData(int id)
        {
            return _adminRepository.UpdateOneVehicleData(id);
        }

        public List<Service> GetServiceList()
        {
            return _adminRepository.GetServiceList();
        }

        public bool SaveBooking(Vehicle model, int id)
        {
            return _adminRepository.SaveBooking(model, id);
        }

        public Vehicle GetVehicleBookDetail(int id)
        {
            return _adminRepository.GetVehicleBookDetail(id);
        }

        //public List<Vehicle> FindDataBetweenDates(DateTime startDate, DateTime endDate)
        //{
        //    return _adminRepository.FindDataBetweenDates(startDate, endDate);
        //}
    }
}
