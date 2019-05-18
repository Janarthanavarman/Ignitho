using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class purchaseCart
    {   
        public int productid {get;set;}
        public String productname {get;set;}
        public String productdesc {get;set;}
        public int quantity {get;set;}
        public String offercode {get;set;}
        public String offerPercentage {get;set;}
        public String ActualPrice {get;set;}
        public decimal netPrice{get;set;}
        public String createby {get;set;} 
    }       
}