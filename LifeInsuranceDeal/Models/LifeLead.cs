﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeInsuranceDeal.Models
{
    public class LifeLead
    {
        public int Id { get; set; }
        public DateTime GeneratedDateTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedDateTime { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string PostCode { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProductName { get; set; }
        public int SiteId { get; set; }
        public string Status { get; set; }
        public string Source { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public string MatchType { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;

        public bool SingleOwnership { get; set; } = true;
   
        public string ProductType { get; set; }

        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public int CoverAmount { get; set; }

        public int CoverPeriod { get; set; }
        public bool Smoker { get; set; }
    }
}