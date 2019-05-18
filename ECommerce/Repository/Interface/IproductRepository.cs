

using System.Collections.Generic;
using ECommerce.Models;
namespace ECommerce.Repository    
{    
    public interface IproductRepository    
    {  
          IEnumerable<productModel> getAllProduct() ;
           productModel getProduct(int id) ;       
          bool addProduct(productModel product);        
          bool updateProduct(int id,productModel s) ;  
          bool deleteProduct(int id);
          }    
}