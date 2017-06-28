using System;
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

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter {0}")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter {0}")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        public decimal Salary { get; set; }

        [Display(Name = "Bonus Percent")]
        public float BonusPercent { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "You must enter {0}")]
        public DateTime StartTime { get; set; }
        
        public string EMail { get; set; }

        public string URL { get; set; }
        //foreign key

        [Display(Name = "Document Type")]
        [Required(ErrorMessage = "You must enter {0}")]
        public int DocumentId { get; set; }

        public virtual DocumentType DocumentType { get; set; }

    }
}