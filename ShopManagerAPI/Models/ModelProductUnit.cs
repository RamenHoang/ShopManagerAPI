using Microsoft.Ajax.Utilities;
using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "ProductUnit")]
    public class ModelProductUnit
    {
        private EntitySet<ModelSellingPrice> _SellingPrices = new EntitySet<ModelSellingPrice>();
        private EntitySet<ModelInputPrice> _InputPrices = new EntitySet<ModelInputPrice>();
        private EntitySet<ModelProductUnitRatio> _ProductUnitRatios = new EntitySet<ModelProductUnitRatio>();

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Unit")]
        public string Unit { get; set; }

        [Association(Name = MyConst.FK_SELLING_PRICE_TO_PRODUCT_UNIT, Storage = "_SellingPrices", OtherKey = "IdProductUnit")]
        public EntitySet<ModelSellingPrice> SellingPrices
        {
            get
            {
                return this._SellingPrices;
            }
            set
            {
                this._SellingPrices.Assign(value);
            }
        }

        [Association(Name = MyConst.FK_SELLING_PRICE_TO_PRODUCT_UNIT, Storage = "_InputPrices", OtherKey = "IdProductUnit")]
        public EntitySet<ModelInputPrice> InputPrices
        {
            get
            {
                return this._InputPrices;
            }
            set
            {
                this._InputPrices.Assign(value);
            }
        }

        [Association(Name = MyConst.FK_PRODUCT_UNIT_RATIO_TO_PRODUCT_UNIT, Storage = "_ProductUnitRatios", OtherKey = "IdProductUnit")]
        public EntitySet<ModelProductUnitRatio> ProductUnitRatios
        {
            get
            {
                return this._ProductUnitRatios;
            }
            set
            {
                this._ProductUnitRatios.Assign(value);
            }
        }
    }
}