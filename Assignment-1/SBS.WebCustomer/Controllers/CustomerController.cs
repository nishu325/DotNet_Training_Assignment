using SBS.BAL.Interface;
using SBS.Models;
using System.Web.Mvc;

namespace SBS.WebCustomer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        [Route("Customer/BookAppointment")]
        [HttpGet]
        public ActionResult Book()
        {
            return View();
        }

        [Route("Customer/BookAppointment")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Book(Vehicle model)
        {
            int id = (int)Session["Id"];
            bool result = _customerManager.Book(model, id); //book appointment of vehicle service.
            if (result)
                return RedirectToAction("Home", "Customer");
            return View();
        }

        [Route("Customer/HomePage")]
        [HttpGet]
        public ActionResult Home()
        {
            int id = (int)Session["Id"];
            return View(_customerManager.GetData(id)); //get the data(booking appointments) of current loggedin user.
        }

        [Route("Customer/LoginPage")]
        [HttpGet]
        public ActionResult CustomerLogin()
        {
            return View();
        }

        [Route("Customer/LoginPage")]
        [HttpPost]        
        public ActionResult CustomerLogin(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var id = _customerManager.Login(email, password); //check customer email & password for login.
                if (id != 0)
                {
                    Session["Id"] = id;
                    return RedirectToAction("Home", "Customer");
                }
            }
            return View();
        }

        [Route("Customer/RegistrationPage")]
        [HttpGet]
        public ActionResult CustomerRegistration()
        {
            return View();
        }

        [Route("Customer/RegistrationPage")]
        [HttpPost]
        public ActionResult CustomerRegistration(Customer model)
        {
            bool result = _customerManager.Register(model); //For new customer registration with all details.
            if (result)
                return RedirectToAction("CustomerLogin", "Customer");
            return View();
        }
    }
}