using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LifeInsuranceDeal.Models
{
    public class CompleteFormModel
    {
        public int Id { get; set; }
        public DateTime GeneratedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string HomePhone { get; set; }
        
        public string WorkPhone { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public int Day { get; set; }
        [Required]
        public int Month { get; set; }
        [Required]
        public int Year { get; set; }

        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public bool Smoker { get; set; }
 

    }
}