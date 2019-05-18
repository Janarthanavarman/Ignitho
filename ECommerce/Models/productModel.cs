using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class productModel
    { 
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        [Required(ErrorMessage="Please enter product code"),MaxLength(10)]                  
        public String productcode { get; set; }
        [Required(ErrorMessage="Please enter name"),MaxLength(50)]
        public String name {get;set;}
        [Required(ErrorMessage="Please enter product type"),MaxLength(10)]
        public String type {get;set;}
         [Required(ErrorMessage="Please enter product description"),MaxLength(500)]
        public String description {get;set;}
        [Required(ErrorMessage="Please enter product price"),DataType(DataType.Currency)]
        public Decimal price {get;set;}
        [Required(ErrorMessage="Please enter product quantity")]
        public int quantity {get;set;} 
        public char status {get;set;}            
        public DateTime createon {get;set;}
        public int createby {get;set;}         
        public int offerrefid { get; set; }
        [ForeignKey("offerrefid")]
        public virtual offerModel offer { get; set; }


       public productModel(){
            this.createon = System.DateTime.Now;
            this.createby = 1;
            this.status= 'A';
        }
    }    
    }