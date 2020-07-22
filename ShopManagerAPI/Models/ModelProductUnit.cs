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

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Unit")]
        public string Unit { get; set; }

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