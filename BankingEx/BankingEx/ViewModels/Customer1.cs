﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BankingEx.ViewModels
{
    public partial class Customer1
    {
        public Customer1()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of Birth must be requird!")]
        public DateTime Dob { get; set; }
        [Required]
        [MaxLength(10)]
        [RegularExpression("[A-Z]{5}[0-9]{4}[A-Z]{1}")]
        public string PanNumber { get; set; }
        [Required]
        public string City { get; set; }
        [NotMapped]        
        public int? Number { get; set; }
        public string State { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
