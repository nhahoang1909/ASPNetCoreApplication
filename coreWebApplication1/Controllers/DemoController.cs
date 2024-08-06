using coreWebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreWebApplication1.Controllers
{
    public class DemoController : Controller
    {
        private static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 101, Name = "King", Amount = 12000},
            new Customer() {Id = 102, Name = "Queen", Amount = 12000}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;

            return View();
        }
        public IActionResult Details()
        {
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"] = customers;

            return View();
        }
        public IActionResult Method1()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;

            return View();
        }
        public IActionResult Method2()
        {
            if (TempData["Message"] == null) return RedirectToAction("Index");
            TempData["Message"] = TempData["Message"].ToString();
            return View();
        }
        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "nhahoang");
            return RedirectToAction("Success");
        }
        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
        public IActionResult QueryTest()
        {
            string name = "Nha Hoang";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"])) name = HttpContext.Request.Query["name"];
            ViewBag.Name = name;
            return View();
        }
    }
}
