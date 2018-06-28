using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeInsuranceDeal.Models
{
    public class FilterModel
    {

        [Required]
        public bool SingleOwnership { get; set; } = true;
        [Required]
        public string ProductType { get; set; }

        [Required]
        public int CoverAmount { get; set; }
        [Required]
        public int CoverPeriod { get; set; }
    }
}