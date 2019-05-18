using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class customerModel
    { 
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        [Display(Name = "customer code")]
        [Required(ErrorMessage="Please enter customer id"),MaxLength(10)]              
        public String custid { get; set; }
        [Required(ErrorMessage="Please enter name"),MaxLength(50)]
        public String name {get;set;}
        [Required(ErrorMessage="Please enter phone number"),MaxLength(10),DataType(DataType.PhoneNumber)]
        public String phone {get;set;}
        [Required(ErrorMessage="Please select gender"),MaxLength(6)]
        public String gender {get;set;}
        [Required(ErrorMessage="Please enter address"),MaxLength(500)]
        public String address {get;set;}

        //  [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        // public DateTime DOB { get; set; }

        public char status {get;set;}     
        public DateTime createon {get;set;}
        public int createby {get;set;}


        public customerModel(){
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