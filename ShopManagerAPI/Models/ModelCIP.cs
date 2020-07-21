using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="CIP")]
    public class ModelCIP
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "idProduct")]
        public int? IdProduct { get; set; }

        [Column(Name = "idUnit")]
        public int? idUnit { get; set; }

        [Column(Name = "UPr", DbType = "float")]
        public float? UnitProduct { get; set; }

        [Column(Name = "APr", DbType = "float")]
        public float? AmountProduct { get; set; }

        [Column(Name = "SeLo")]
        public string SeriesLot { get; set; }

        [Column(Name = "DaProd")]
        public DateTime? DateProduct { get; set; }

        [Column(Name = "DaExp")]
        public DateTime? DateExpiration { get; set; }

        [Column(Name = "Q", DbType = "float")]
        public float? Quantity { get; set; }

        [Column(Name = "RQ", DbType = "float")]
        public float? RQ { get; set; }

        [Column(Name = "ImDa")]
        public DateTime? DateImport { get; set; }

        [Column(Name = "idSuppl")]
        public int? idSupplier { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "idInv")]
        public int? IdInvoice { get; set; }
    }
}