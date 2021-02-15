using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS.DAL.Repository.Interface
{
    public interface IAdminRepository
    {
        Vehicle UpdateOneVehicleData(int id);
        Vehicle GetVehicleBookDetail(int id);
        bool CreateDealer(Dealer model);
        List<Dealer> GetDealerList();
        List<Vehicle> GetVehicleData();
        bool CreateMechanic(Mechanic model);
        List<Service> GetServiceList();
        List<Mechanic> GetMechanicData();
        bool CreateService(Service model);
        bool SaveBooking(Vehicle model, int id);
    }
}
