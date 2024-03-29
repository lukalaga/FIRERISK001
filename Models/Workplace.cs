﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FIRERISK.Models
{
    public class Workplace
    {
        [Key]
        public string RegID { get; set; }

        [Display(Name ="Workplace Name")]
        public string WorkplaceName { get; set; }

        [Display(Name ="Postal Address")]
        public string PostalAddress { get; set; }

        [Display(Name ="Physical Address")]
        public string PhysicalAddress { get; set; }

        [Display(Name ="Male Employees")]
        public int MaleEmployees { get; set; }

        [Display(Name ="Female Employees")]
        public int FemaleEmployees { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Site Description")]
        public string SiteDescription { get; set; }

        public int OnAttachment { get; set; }

        public int DisabledNo { get; set; }

        public string HealthOfficer { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string IndustryID { get; set; }

        public virtual Industry Industry { get; set; }
               
    }
}