using System;    
using System.Collections.Generic;    
using System.Data;    
using System.Data.SqlClient;    
using System.Linq;    
using System.Threading.Tasks;
using ECommerce.Models;
namespace ECommerce.Repository    
{    
    public class productRepository    :IproductRepository
    {    
            // "DefaultConnection": "Server=tcp:xxUAT.domain.com,64609;Initial Catalog=IdentityDB;MultipleActiveResultSets=true;User ID=xx;Password=xx"
       eCommIMContext context;
       public  productRepository(eCommIMContext context)
        {
            this.context=context;
        }
        public IEnumerable<productModel> getAllProduct()    
        {               
            return context.productModel.Where(x=> x.status =='A').ToList();    
        }


        public productModel getProduct(int id)    
        {                        
            return context.productModel.Where(x => x.id ==id && x.status =='A').FirstOrDefault(); 
        }

      
      
        public bool addProduct(productModel coustomer)    
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

          public bool updateProduct(int id,productModel s)    
        {    
          try{

              var product = context.productModel.Where(x=>x.id ==id && x.status =='A').FirstOrDefault();
              if(product!=null){
                  product.productcode =s.productcode;
                  product.name =s.name;
                  product.type =s.type;
                  product.description =s.description;
                  product.price =s.price;
                  product.quantity =s.quantity;
                  product.createon = System.DateTime.Now;

               context.productModel.Update(product);
               context.SaveChanges();
               return true;
              }
            return false;
          }catch(Exception ex){
              Console.Write(ex.Message);
                return false;
          }                   
          
        }


        public bool deleteProduct(int id)
        {            
            try
           {        
                var std = context.productModel.Where(x=>x.id ==id).FirstOrDefault();
              if(std!=null){       
              // context.productDetails.Remove(std);
               std.status ='D';
               context.productModel.Update(std);             
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