using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "ProductInfo")]
    public class ModelProductInfo
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "ProductName")]
        public string ProductName { get; set; }

        [Column(Name = "idLocation")]
        public int? IdLocation { get; set; }

        [Column(Name = "BarCode")]
        public string BarCode { get; set; }

        [Column(Name = "NumReg")]
        public string NumReg { get; set; }

        [Column(Name = "ContentQuantity")]
        public string ContentQuantity { get; set; }

        [Column(Name = "BarCode_Origin")]
        public string BarCodeOrigin { get; set; }

        [Column(Name = "stopSelling")]
        public bool? StopSelling { get; set; }

        [Column(Name = "T_Code_01")]
        public string TCode01 { get; set; }

        [Column(Name = "T_Code_02")]
        public string TCode02 { get; set; }

        [Column(Name = "T_Unit_01")]
        public string TUnit01 { get; set; }

        [Column(Name = "T_Unit_02")]
        public string TUnit02 { get; set; }


        [Column(Name = "T_Description_01")]
        public string TDescription01 { get; set; }

        [Column(Name = "T_Description_02")]
        public string TDescription02 { get; set; }


    }
}