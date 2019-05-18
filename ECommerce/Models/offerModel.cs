using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class offerModel
    { 
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        [Required(ErrorMessage="Please enter offer code"),MaxLength(10)]              
        public String offercode { get; set; }
        [Required(ErrorMessage="Please enter name"),MaxLength(50)]
        public String name {get;set;}       
         [Required(ErrorMessage="Please enter offer description"),MaxLength(500)]
        public String description {get;set;}
        [Required(ErrorMessage="Please enter offer percentage"),DataType(DataType.Currency),Range(0.0,99.99)]
        public Decimal percentage {get;set;}       
        public char status {get;set;}           
        public DateTime createon {get;set;}
        public int createby {get;set;} 
        public virtual ICollection<productModel> productModel { get; set; }
        public offerModel(){
            this.createon = System.DateTime.Now;
            this.createby = 1;
            this.status= 'A';
        }
    }
}