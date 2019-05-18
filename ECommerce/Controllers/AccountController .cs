
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Security.Claims;  
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerce.Repository;
using Microsoft.AspNetCore.Authentication;  
using Microsoft.AspNetCore.Authentication.Cookies;  
using Microsoft.AspNetCore.Mvc; 

namespace ECommerce.Controllers
{
    public class AccountController  : Controller
    {
        //StudentDataAccessLayer obj_customer = new StudentDataAccessLayer();
        IcustomerRepository obj_customer;
        public AccountController (IcustomerRepository obj_customer){
            this.obj_customer =obj_customer;
        }
        
        public IActionResult Login()  
        {  
             var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();  
        }   
       

            [HttpPost]
        public IActionResult Login([Bind] loginModel login)
        {
          if(!string.IsNullOrEmpty(login.name) && !string.IsNullOrEmpty(login.password)&& string.IsNullOrEmpty(login.type))  
            {  
                return RedirectToAction("Login");  
            }  

            //Check the user name and password
            //Here can be implemented checking logic from the database
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if (login.type=="User" &&  login.name.ToUpper().Trim()=="ADMIN" && login.password == "1234"){
                
                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, login.name),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }else
            if ( obj_customer.getAllCustomer().Any(x=> x.custid.ToUpper().Trim() == login.name.ToUpper().Trim()) &&  login.password == "12345")
            {
                //Create the identity for the user
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,  login.name),
                    new Claim(ClaimTypes.Role, "Customer")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                var logi = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if(login.type=="User")
                    return RedirectToAction("Index", "customer");
                else
                    return RedirectToAction("Index", "purchase");
            }

            ModelState.AddModelError("validatetion","Invalid credential");
            return View();
        }

        
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }



    }
}