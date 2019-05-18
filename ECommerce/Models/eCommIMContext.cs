using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Models
{
    public class eCommIMContext : DbContext
    {

        public eCommIMContext(DbContextOptions<eCommIMContext> DBIM) : base(DBIM)
        {
            if(customerModel.ToListAsync().Result.Count==0)
            {
               customerModel.Add(new customerModel(){
                  custid="1",name="AutoGen",address="Com",phone="1234567890",gender="Male"
               });
            }   

             if(offerModel.ToListAsync().Result.Count==0)
            {
               offerModel.Add(new offerModel(){
                  offercode="1",name="AutoGen", description="Com",percentage=12
               });
            }   

                 

            SaveChanges();
        }
        public DbSet<customerModel> customerModel{get;set;}
        public DbSet<productModel> productModel{get;set;}
        public DbSet<offerModel> offerModel{get;set;}
          public DbSet<purchaseModel> purchaseModel{get;set;}


        
    }
}