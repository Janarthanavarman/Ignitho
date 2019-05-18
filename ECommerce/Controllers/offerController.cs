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
    public class offerController : Controller
    {
        //StudentDataAccessLayer obj_offer = new StudentDataAccessLayer();
        IofferRepository obj_offer;
        public offerController(IofferRepository obj_offer){
            this.obj_offer =obj_offer;
        }
        
        public IActionResult Index()
        {
            List<offerModel> offers = new List<offerModel>();
            offers = obj_offer.getAllOffer().ToList();

            return View(offers);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create([Bind] offerModel offer)
        {
            if (ModelState.IsValid)
            {
                 if(obj_offer.getAllOffer().Any(x=> x.offercode.ToUpper() ==offer.offercode.ToUpper())){
                     ModelState.AddModelError("productcode","Offer code already exists");                     
                 }else{

                obj_offer.addOffer(offer);
                return RedirectToAction("Index");
                 }
            }
            return View(offer);
        }


        public IActionResult Edit(int id)
        {
            return View(obj_offer.getOffer(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,[Bind] offerModel offer)
        {
            if (ModelState.IsValid)
            {
                if(obj_offer.getAllOffer().Any(x=> x.id !=id &&  x.offercode.ToUpper() ==offer.offercode.ToUpper())){
                     ModelState.AddModelError("productcode","Offer code already exists");                     
                 }else{
                obj_offer.updateOffer(id,offer);
                   return RedirectToAction("Index");
                 }
            }
            return View(offer);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            obj_offer.deleteOffer(id);
            return RedirectToAction("Index");
        }


    }
}