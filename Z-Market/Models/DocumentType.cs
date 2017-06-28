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

        [Display(Name = "Document")]
        public string Description { get; set; }

        [Display(Name = "Document Type")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}