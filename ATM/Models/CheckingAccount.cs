﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"\d{6,10}")]
        [Display(Name= "Account #")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

         public string Name
         {
             get
             {
                 return string.Format("{0} {1}", this.FirstName, this.LastName);
             }
         }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}