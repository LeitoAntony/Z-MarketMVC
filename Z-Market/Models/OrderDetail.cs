using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId{ get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters!", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter the field {0}!")]
        [Display(Name = "Producto Description")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]//numero sin coma
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter the field {0}!")]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]//numero sin coma
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter the field {0}!")]
        public float Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

    }
}