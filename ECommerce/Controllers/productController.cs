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
     [Authorize(Roles ="Admin")]    
      public class productController : Controller
    {
        //StudentDataAccessLayer obj_Product = new StudentDataAccessLayer();
        IproductRepository obj_Product;IofferRepository iofferRepository;
        public productController(IproductRepository obj_Product,IofferRepository iofferRepository ){
            this.obj_Product =obj_Product;
            this.iofferRepository =iofferRepository;
        }
        
        public IActionResult Index()
        {
            List<productModel> Products = new List<productModel>();
            Products = obj_Product.getAllProduct().ToList();
            

            return View(Products);
        }

        [HttpGet]
        public IActionResult create()
        {

            var OfferList = iofferRepository.getAllOffer().Select(x=> new { 
                offerid = x.id,
                 offername = x.offercode + x.name
            });
            SelectList list = new SelectList(OfferList, "offerid", "offername");  
            ViewBag.offers = list;  
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult create([Bind] productModel Product)
        {
            if (ModelState.IsValid)
            {

                 if(obj_Product.getAllProduct().Any(x=> x.productcode.ToUpper() ==Product.productcode.ToUpper())){
                     ModelState.AddModelError("productcode","Product code already exists");                     
                 }else{

                obj_Product.addProduct(Product);
                return RedirectToAction("Index");
                 }
            }

               
          
            ViewBag.offers = iofferRepository. selectList();
            return View(Product);
        }


        public IActionResult Edit(int id)
        {            
            ViewBag.offers =iofferRepository. selectList(); 
            
            return View(obj_Product.getProduct(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,[Bind] productModel Product)
        {
            if (ModelState.IsValid)
            {

                  if(obj_Product.getAllProduct().Any(x=> x.id!=id &&  x.productcode.ToUpper() ==Product.productcode.ToUpper())){
                     ModelState.AddModelError("productcode","Product code already exists");                     
                 }else{


                obj_Product.updateProduct(id,Product);
                return RedirectToAction("Index");
                 }
            }
            ViewBag.offers = iofferRepository. selectList();
            return View(Product);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            obj_Product.deleteProduct(id);
            return RedirectToAction("Index");
        }


    }
}