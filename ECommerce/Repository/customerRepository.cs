using System;    
using System.Collections.Generic;    
using System.Data;    
using System.Data.SqlClient;    
using System.Linq;    
using System.Threading.Tasks;
using ECommerce.Models;

namespace ECommerce.Repository    
{    
    public class customerRepository    :IcustomerRepository
    {    
            // "DefaultConnection": "Server=tcp:xxUAT.domain.com,64609;Initial Catalog=IdentityDB;MultipleActiveResultSets=true;User ID=xx;Password=xx"
       eCommIMContext context;
       public  customerRepository(eCommIMContext context)
        {
            this.context=context;
        }
        public IEnumerable<customerModel> getAllCustomer()    
        {               
            return context.customerModel.Where(x=> x.status =='A').ToList();    
        }


        public customerModel getCustomer(int id)    
        {                        
            return context.customerModel.Where(x => x.id ==id && x.status =='A').FirstOrDefault(); 
        }

      
      
        public bool addCustomer(customerModel coustomer)    
        {    
          try{
            coustomer.createon =System.DateTime.Now;
            coustomer.createby =1;
           context.Add(coustomer);
           context.SaveChanges();
           return true;
          }
          catch{
            return  false;
          }
        }

          public bool updateCustomer(int id,customerModel s)    
        {    
          try{

              var customer = context.customerModel.Where(x=>x.id ==id && x.status =='A').FirstOrDefault();
              if(customer!=null){
                  customer.custid =s.custid;
                  customer.name =s.name;
                  customer.phone =s.phone;
                  customer.gender =s.gender;
                  customer.address =s.address;
                  customer.createon = System.DateTime.Now;

               context.customerModel.Update(customer);
               context.SaveChanges();
               return true;
              }
            return false;
          }catch(Exception ex){
              Console.Write(ex.Message);
                return false;
          }                   
          
        }


        public bool deleteCustomer(int id)
        {            
            try
           {        
                var std = context.customerModel.Where(x=>x.id ==id).FirstOrDefault();
              if(std!=null){       
               //context.customerModel.Remove(std);
               std.status ='D';
               context.customerModel.Update(std);
               context.SaveChanges();
               return true;
              }
              return false;
            }catch(Exception ex){
              Console.Write(ex.Message);
                return false;
          }             
          
        }
    }    
}