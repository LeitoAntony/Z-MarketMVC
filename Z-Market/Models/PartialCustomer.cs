using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public partial class Customer
    {
        [NotMapped]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } set { ; } }
    }
}