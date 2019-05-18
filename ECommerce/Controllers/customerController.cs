using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Repository;
using Microsoft.AspNetCore.Authorization;

namespace ECommerce.Controllers
{
    [Authorize(Roles ="Admin")] 
     public class customerController : Controller
    {
        //StudentDataAccessLayer obj_customer = new StudentDataAccessLayer();
        IcustomerRepository obj_customer;
        public customerController(IcustomerRepository obj_customer){
            this.obj_customer =obj_customer;
        }
        
        public IActionResult Index()
        {
            List<customerModel> customers = new List<customerModel>();
            customers = obj_customer.getAllCustomer().ToList();

            return View(customers);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create([Bind] customerModel customer)
        {
            if (ModelState.IsValid)
            {
                 if(obj_customer.getAllCustomer().Any(x=>  x.custid.ToUpper() ==customer.custid.ToUpper())){
                     ModelState.AddModelError("productcode","Customer code already exists");                     
                 }else{

                obj_customer.addCustomer(customer);
                return RedirectToAction("Index");
                 }
            }
            return View(customer);
        }


        public IActionResult Edit(int id)
        {
            return View(obj_customer.getCustomer(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,[Bind] customerModel customer)
        {
            if (ModelState.IsValid)
            {
                 if(obj_customer.getAllCustomer().Any(x=> x.id!= id && x.custid.ToUpper() ==customer.custid.ToUpper())){
                     ModelState.AddModelError("productcode","Customer code already exists");                     
                 }else{
                obj_customer.updateCustomer(id,customer);
                return RedirectToAction("Index");
                 }
            }
            return View(customer);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            obj_customer.deleteCustomer(id);
            return RedirectToAction("Index");
        }


    }
}