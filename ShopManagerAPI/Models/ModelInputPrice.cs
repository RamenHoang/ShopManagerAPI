using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "InputPrice")]
    public class ModelInputPrice
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "idProduct")]
        public int IdProduct { get; set; }

        [Column(Name = "idUnit_Import")]
        public int IdUnitImport { get; set; }

        [Column(Name = "Quantity", DbType = "float")]
        public float Quantity { get; set; }

        [Column(Name = "UnitPriceNoVAT", DbType = "float")]
        public float? UnitPriceNoVAT { get; set; }

        [Column(Name = "AmountWithVAT", DbType = "float")]
        public float AmountWithVAT { get; set; }

        [Column(Name = "SeriesLot")]
        public string SeriesLot { get; set; }

        [Column(Name = "DateProduction")]
        public DateTime? DateProduction { get; set; }

        [Column(Name = "DateExpiration")]
        public DateTime DateExpiration { get; set; }

        [Column(Name = "idInvoice")]
        public int? IdInvoice { get; set; }

        [Column(Name = "RQ", DbType = "float")]
        public float? RQ { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "AmountRefund", DbType = "float")]
        public float AmountRefund { get; set; }

        [Column(Name = "AmountFinal", DbType = "float")]
        public float AmountFinal { get; set; }

        [Column(Name = "stock")]
        public float Stock { get; set; }

        [Column(Name = "QuantityBase", DbType = "float")]
        public float? QuantityBase { get; set; }

        [Column(Name = "RQBase", DbType = "float")]
        public float? RQBase { get; set; }

        [Column(Name = "RatioBase", DbType = "float")]
        public float? RatioBase { get; set; }

        [Column(Name = "idUnit_Ratio")]
        public int? idUnit_Ratio { get; set; }
    }
}