

using System.Collections.Generic;
using ECommerce.Models;
namespace ECommerce.Repository    
{    
    public interface IpurchaseRepository    
    {  
          IEnumerable<purchaseModel> getAllPurchase() ;
           purchaseModel getPurchase(int id) ;       
          bool addPurches(purchaseModel purchase); 
         
          }    
}