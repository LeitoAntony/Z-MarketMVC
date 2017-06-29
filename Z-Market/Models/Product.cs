using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Z_Market.Models
{
    public class Product
    {

        //Data notation, autonumerico
        [Key]
        public int ProductId { get; set; }

        [StringLength(30, ErrorMessage= "The field {0} must contain between {2} and {1} characters!", MinimumLength =3)]
        [Required(ErrorMessage= "You must enter the field {0}!")]
        [Display(Name= "Producto Description")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]//numero sin coma
        [DisplayFormat(DataFormatString= "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter the field {0}!")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Last Buy")]
        public DateTime LastBuy { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public float Stock { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}