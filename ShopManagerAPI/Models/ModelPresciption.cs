using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="Presciption")]
    public class ModelPresciption
    {
        // Define Column get set
        [Column(Name = "ID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "BarCode")]
        public string BarCode { get; set; }

        [Column(Name = "RealAmount", DbType = "float")]
        public float RealAmount { get; set; }

        [Column(Name = "SellingAmount", DbType = "float")]
        public float SellingAmount { get; set; }

        [Column(Name = "GroupPrescript")]
        public int? GroupPrescript { get; set; }

        [Column(Name = "counter")]
        public int? Counter { get; set; }

        [Column(Name = "stopSelling")]
        public bool CtopSelling { get; set; }

        [Column(Name = "DetailVisible")]
        public bool DetailVisible { get; set; }
    }
}