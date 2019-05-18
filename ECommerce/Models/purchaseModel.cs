using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class purchaseModel
    { 
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        
        public int customerrefid {get;set;}

         [ForeignKey("customerrefid")]
        public virtual customerModel customerModel { get; set; }

        public int productrefid {get;set;} 

         [ForeignKey("productrefid")]
        public virtual productModel productModel { get; set; }

        public String offercode { get; set; }

        public Decimal percentage {get;set;}       
        
        [Required(ErrorMessage="Please enter quantity")]
        public int quantity {get;set;}
        
        public Decimal actualprice {get;set;}
        
        public Decimal netprice {get;set;}       // if offer applicable  actual - (actual* offer/100)


        //  [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // public DateTime DOB { get; set; }

        public char status {get;set;}     
        public DateTime createon {get;set;}
        public int createby {get;set;}


        public purchaseModel(){
            this.createon = System.DateTime.Now;
            this.createby = 1;
            this.status= 'A';
        }

        // [Display(Name = "birth date")]
        // [Required(ErrorMessage = "Birth Date is required.")]
        // [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]   
        // public DateTime dob {get;set;}
    }       
}