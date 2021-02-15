using SBS.BAL.Interface;
using SBS.Models;
using System.Web.Mvc;

namespace SBS.WebAdmin.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _adminManager;
        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }
        [Route("Admin/HomePage")]
        [HttpGet]
        public ActionResult Home()
        {
            var vehicleData = _adminManager.GetVehicleData();  //get all vehicle booking request from database.
            return View(vehicleData);
        }
       
        [Route("Admin/VehicleBookingDetail")]
        [HttpGet]
        public ActionResult GetVehicleData(int id)
        {
            var data = _adminManager.GetVehicleBookDetail(id); //get perticular vehicle booking detail.
            return View(data);
        }
       
        [Route("Admin/UpdateVehicleBooking")]
        [HttpGet]
        public ActionResult UpdateOneVehicleData(int id)
        {
            var data = _adminManager.GetDealerList();
            if (data != null)
                ViewBag.Dealer = data;

            var data1 = _adminManager.GetMechanicData();
            if (data1 != null)
                ViewBag.Mechanic = data1;

            var data3 = _adminManager.GetServiceList();
            if (data3 != null)
                ViewBag.Service = data3;

            Vehicle data4 = _adminManager.UpdateOneVehicleData(id); //get perticular vehicle details by GET method.
            Session["Id"] = data4.Id;
            return View(data4);
        }

        [Route("Admin/UpdateVehicleBooking")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateOneVehicleData(Vehicle model, int id)
        {
            bool result = _adminManager.SaveBooking(model, id); //Confirm the booking request and assign mechanic,dealer,and service for perticular vehicle.
            if (result)
                return RedirectToAction("Home", "Admin");
            return View();
        }

        [Route("Admin/CreateNewDealer")]
        [HttpGet]
        public ActionResult CreateDealer()
        {
            return View();
        }

        [Route("Admin/CreateNewDealer")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDealer(Dealer model)
        {
            bool data = _adminManager.CreateDealer(model);  //create new dealer with all details.
            if (data)
                return RedirectToAction("Home", "Admin");
            return View();
        }

        [Route("Admin/CreateNewMechanic")]
        [HttpGet]
        public ActionResult CreateMechanic()
        {           
            return View();
        }

        [Route("Admin/CreateNewMechanic")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMechanic(Mechanic model)
        {
            bool data = _adminManager.CreateMechanic(model); //Register new mechanic with all details.
            if (data)
                return RedirectToAction("Home", "Admin");
            return View();
        }

        [Route("Admin/CreateNewService")]
        [HttpGet]
        public ActionResult CreateService()
        {          
            return View();
        }

        [Route("Admin/CreateNewService")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateService(Service model)
        {
            bool data = _adminManager.CreateService(model); //register new service 
            if (data)
                return RedirectToAction("Home", "Admin");
            return View();
        }
    }
}