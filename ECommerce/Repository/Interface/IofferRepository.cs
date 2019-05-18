

using System.Collections.Generic;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Repository    
{    
    public interface IofferRepository    
    {  
          IEnumerable<offerModel> getAllOffer() ;
           offerModel getOffer(int id) ;       
          bool addOffer(offerModel product);        
          bool updateOffer(int id,offerModel s) ;  
          bool deleteOffer(int id);
          SelectList selectList();
    }    
}