using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Repository
{
    public class offerRepository : IofferRepository
    {
        // "DefaultConnection": "Server=tcp:xxUAT.domain.com,64609;Initial Catalog=IdentityDB;MultipleActiveResultSets=true;User ID=xx;Password=xx"
        eCommIMContext context;
        public offerRepository(eCommIMContext context)
        {
            this.context = context;
        }
        public IEnumerable<offerModel> getAllOffer()
        {
            return context.offerModel.Where(x => x.status == 'A').ToList();
        }

        public offerModel getOffer(int id)
        {
            return context.offerModel.Where(x => x.id == id && x.status == 'A').FirstOrDefault();
        }



        public bool addOffer(offerModel offer)
        {
            try
            {
                offer.createon = System.DateTime.Now;
                offer.createby = 1;
                context.Add(offer);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateOffer(int id, offerModel s)
        {
            try
            {

                var offer = context.offerModel.Where(x => x.id == id && x.status == 'A').FirstOrDefault();
                if (offer != null)
                {
                    offer.offercode = s.offercode;
                    offer.name = s.name;
                    offer.description = s.description;
                    offer.percentage = s.percentage;
                    offer.createon = System.DateTime.Now;

                    context.offerModel.Update(offer);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

        }


        public bool deleteOffer(int id)
        {
            try
            {
                var std = context.offerModel.Where(x => x.id == id).FirstOrDefault();
                if (std != null)
                {
                    //context.offerDetails.Remove(std);
                    std.status = 'D';
                    context.offerModel.Update(std);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }

        }


        public SelectList selectList()
        {
            try
            {
                var OfferList = this.getAllOffer().Select(x => new
                {
                    offerid = x.id,
                    offername = x.offercode + x.name
                });
                return new SelectList(OfferList, "offerid", "offername");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }

        }
    }
}