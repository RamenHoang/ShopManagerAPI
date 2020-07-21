using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="PrescriptionContent")]
    public class ModelPrescriptionContent
    {
        [Column(Name = "idPrescription")]
        public int IdPrescription { get; set; }

        [Column(Name = "idProductInfo")]
        public int IdProductInfo { get; set; }

        [Column(Name = "idUnit")]
        public int? IdUnit { get; set; }

        [Column(Name = "quant", DbType = "float")]
        public float? Quantity { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }
}