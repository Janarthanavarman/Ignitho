
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class loginModel
    { 
        
         [Required(ErrorMessage="Please select type of user")]
        public String type {get;set;}
        [Required(ErrorMessage="Please enter name")]
        public String name {get;set;}
        [Required(ErrorMessage="Please enter password"),DataType(DataType.Password)]
        public String password {get;set;}
        public String validatetion {get;set;}
    }       
}