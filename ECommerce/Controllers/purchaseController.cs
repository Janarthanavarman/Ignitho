using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace ECommerce.Controllers
{
     [Authorize(Roles ="Customer")]    
      public class purchaseController : Controller
    {
        //StudentDataAccessLayer obj_Product = new StudentDataAccessLayer();
        IproductRepository obj_Product;
        IofferRepository iofferRepository;

        
        public purchaseController(IproductRepository obj_Product,IofferRepository iofferRepository ){
            this.obj_Product =obj_Product;
            this.iofferRepository =iofferRepository;
        }
        
        public IActionResult Index()
        {
            List<productModel> Products = new List<productModel>();
            Products = obj_Product.getAllProduct().ToList();            

            return View(Products);
        }

       


    }
}