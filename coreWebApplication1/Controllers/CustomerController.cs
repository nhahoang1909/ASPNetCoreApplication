using coreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 101, Name = "King", Amount = 12000},
            new Customer() {Id = 102, Name = "Queen", Amount = 12000}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count;
            ViewBag.CustomerList = customers;
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }
    }
}
