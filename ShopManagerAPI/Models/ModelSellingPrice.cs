using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "SellingPrice")]
    public class ModelSellingPrice
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "idUnit")]
        public int? IdUnit { get; set; }

        [Column(Name = "Ratio", DbType = "float")]
        public float? Ratio { get; set; }

        [Column(Name = "ProfitsPercent", DbType = "float")]
        public float? ProfitsPercent { get; set; }

        [Column(Name = "SellingPrice", DbType = "float")]
        public float? SellingPrice { get; set; }

        [Column(Name = "idProductInfo")]
        public int? IdProductInfo { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "Actual")]
        public bool? Actual { get; set; }

        [Column(Name = "creationDate")]
        public DateTime CreationDate;

        [Column(Name = "order")]
        public int? Order { get; set; }
    }
}