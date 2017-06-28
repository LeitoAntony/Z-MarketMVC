﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public float BonusPercent { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartTime { get; set; }
        public string EMail { get; set; }
        public string URL { get; set; }
        //foreign key
        public int DocumentId { get; set; }

        public virtual DocumentType DocumentType { get; set; }

    }
}