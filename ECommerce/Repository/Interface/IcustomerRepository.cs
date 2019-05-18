

using System.Collections.Generic;
using ECommerce.Models;

namespace ECommerce.Repository    
{    
    public interface IcustomerRepository    
    {  
          IEnumerable<customerModel> getAllCustomer() ;
           customerModel getCustomer(int id) ;       
          bool addCustomer(customerModel coustomer);        
          bool updateCustomer(int id,customerModel s) ;  
          bool deleteCustomer(int id);
    }    
}