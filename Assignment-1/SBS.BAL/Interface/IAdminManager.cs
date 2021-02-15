using SBS.Models;
using System.Collections.Generic;

namespace SBS.BAL.Interface
{
    public interface IAdminManager
    {
        Vehicle UpdateOneVehicleData(int id);
        Vehicle GetVehicleBookDetail(int id);
        List<Vehicle> GetVehicleData();
        bool CreateDealer(Dealer model);
        List<Dealer> GetDealerList();
        List<Service> GetServiceList();
        bool CreateMechanic(Mechanic model);
        List<Mechanic> GetMechanicData();
        bool CreateService(Service model);
        bool SaveBooking(Vehicle model, int id);
    }
}
