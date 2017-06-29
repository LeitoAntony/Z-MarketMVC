using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId{ get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters!", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters!", MinimumLength = 3)]
        [Display(Name = "Contact First Name")]
        public string ContactFirstName { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters!", MinimumLength = 3)]
        [Display(Name = "Contact Last Name")]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters!", MinimumLength = 3)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters!", MinimumLength = 3)]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }


    }
}