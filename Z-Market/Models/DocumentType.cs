using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class DocumentType
    {
        [Key]
        public int DocumentId { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters!")]
        [Required(ErrorMessage = "Ypu must enter the field {0}")]
        [Display(Name = "Document Description")]
        public string Description { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}