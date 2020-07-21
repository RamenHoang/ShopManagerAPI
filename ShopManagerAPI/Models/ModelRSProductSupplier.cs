using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "RS_Product_Supplier")]
    public class ModelRSProductSupplier
    {
        [Column(Name = "idSupplier")]
        public int? IdSupplier { get; set; }

        [Column(Name = "idProduct")]
        public int? IdProduct { get; set; }

        [Column(Name = "status")]
        public int? Status { get; set; }
    }
}