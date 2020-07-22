using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "SellingPrice")]
    public class ModelSellingPrice
    {
        private EntityRef<ModelProductInfo> _ProductInfo = new EntityRef<ModelProductInfo>();
        private EntityRef<ModelProductUnit> _ProductUnit = new EntityRef<ModelProductUnit>();

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "idUnit")]
        public int? IdProductUnit { get; set; }

        [Column(Name = "Ratio", DbType = "float")]
        public float? Ratio { get; set; }

        [Column(Name = "ProfitsPercent", DbType = "float")]
        public float? ProfitsPercent { get; set; }

        [Column(Name = "SellingPrice", DbType = "float")]
        public float? SellingPrice { get; set; }

        [Column(Name = "idProductInfo")]
        public int? IdProduct { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "Actual")]
        public bool? Actual { get; set; }

        [Column(Name = "creationDate")]
        public DateTime CreationDate;

        [Column(Name = "order")]
        public int? Order { get; set; }

        [Column(Name ="F_Ratio_Base")]
        public float? F_Ratio_Base { get; set; }

        [Association(Name = MyConst.FK_SELLING_PRICE_TO_PRODUCT_INFO, Storage = "_ProductInfo", IsForeignKey = true, ThisKey = "IdProduct")]
        public ModelProductInfo ProductInfo
        {
            get
            {
                return this._ProductInfo.Entity;
            }
            set
            {
                this._ProductInfo.Entity = value;
            }
        }

        [Association(Name = MyConst.FK_SELLING_PRICE_TO_PRODUCT_UNIT, Storage = "_ProductUnit", IsForeignKey = true, ThisKey = "IdProductUnit")]
        public ModelProductUnit ProductUnit
        {
            get
            {
                return this._ProductUnit.Entity;
            }
            set
            {
                this._ProductUnit.Entity = value;
            }
        }
    }
}