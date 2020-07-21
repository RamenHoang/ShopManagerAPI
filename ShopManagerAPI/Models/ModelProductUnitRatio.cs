using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="ProductUnitRatio")]
    public class ModelProductUnitRatio
    {
        [Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "idUnit")]
        public int IdUnit { get; set; }

        [Column(Name = "idProduct")]
        public int IdProduct { get; set; }

        [Column(Name = "ratio", DbType = "float")]
        public float Ratio { get; set; }

        [Column(Name = "isBase")]
        public bool IsBase { get; set; }
    }
}