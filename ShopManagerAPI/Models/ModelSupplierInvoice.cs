using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "SupplierInvoice")]
    public class ModelSupplierInvoice
    {
        [Column(Name ="id", IsDbGenerated =true, IsPrimaryKey =true)]
        public int Id { get; set; }

        [Column(Name = "idSupplier")]
        public int IdSupplier { get; set; }

        [Column(Name = "date")]
        public DateTime Date { get; set; }

        [Column(Name = "Num")]
        public string Num { get; set; }

        [Column(Name = "AmountWithVAT", DbType = "float")]
        public float? AmountWithVAT { get; set; }

        [Column(Name = "AmountNoVAT", DbType = "float")]
        public float? AmountNoVAT { get; set; }

        [Column(Name = "Discount", DbType = "float")]
        public float? Discount { get; set; }

        [Column(Name = "DiscountPercent", DbType = "float")]
        public float? DiscountPercent { get; set; }

        [Column(Name = "AmountWithVATFinal", DbType = "float")]
        public float? AmountWithVATFinal { get; set; }

        [Column(Name = "AmountNoVATFinal", DbType = "float")]
        public float? AmountNoVATFinal { get; set; }

        [Column(Name = "stock")]
        public float Stock { get; set; }

        [Column(Name = "inputDate")]
        public DateTime? InputDate { get; set; }

        [Column(Name = "T_Code_01")]
        public string T_Code_01 { get; set; }

        [Column(Name = "T_Code_02")]
        public string T_Code_02 { get; set; }
    }
}
