using AJAX.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJAX.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        //Make a constructor to intialize the data
        public CustomerController()
        {
            customers.Add( new CustomerModel { Id = 1, Name = "John", Age = 10});
            customers.Add(new CustomerModel { Id = 2, Name = "Sherry", Age = 12 });
            customers.Add(new CustomerModel { Id = 3, Name = "Melvin", Age = 14 });
            customers.Add(new CustomerModel { Id = 4, Name = "Lias", Age = 16 });
            customers.Add(new CustomerModel { Id = 5, Name = "Dace", Age = 18 });
            customers.Add(new CustomerModel { Id = 6, Name = "Kavon", Age = 20 });
        }
        public IActionResult Index()
        {
            return View(customers);
        }


        public IActionResult ShowOnePerson(int id)
        {

            CustomerModel customer = customers.FirstOrDefault(x => x.Id == id);
            return PartialView(customer);
        }
    }
}
