using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCContactList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCContactList.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["customers"] = DataManager.GetCustomers();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["customer"] = DataManager.GetCustomerById(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, Customer customer)
        {

            DataManager.EditCustomer(id, customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        public IActionResult Remove(int id)
        {
            DataManager.RemoveCustomer(id);
            return RedirectToAction(nameof(CustomersController.Index));
        }

    }
}
