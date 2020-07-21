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
        private EntitySet<ModelInputPriceC> _InputPriceCs = new EntitySet<ModelInputPriceC>();
        private EntitySet<ModelSellingPrice> _SellingPrices = new EntitySet<ModelSellingPrice>();

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "id")]
        public string Unit { get; set; }

        [Association(Name = MyConst.FK_INPUT_PRICE_C_TO_PRODUCT_UNIT, Storage = "_InputPriceCs", OtherKey = "IdProductUnit")]
        public EntitySet<ModelInputPriceC> InputPriceCs
        {
            get
            {
                return this._InputPriceCs;
            }
            set
            {
                this._InputPriceCs.Assign(value);
            }
        }

        [Association(Name = MyConst.FK_INPUT_PRICE_C_TO_PRODUCT_UNIT, Storage = "_SellingPrices", OtherKey = "IdProductUnit")]
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
    }
}