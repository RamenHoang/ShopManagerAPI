﻿using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "ProductInfo")]
    public class ModelProductInfo
    {
        private EntitySet<ModelRSProductSupplier> _RSProductSuppliers = new EntitySet<ModelRSProductSupplier>();
        private EntitySet<ModelInputPriceC> _InputPriceCs = new EntitySet<ModelInputPriceC>();
        private EntitySet<ModelSellingPrice> _SellingPrices = new EntitySet<ModelSellingPrice>();

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

        [Association(Name = MyConst.FK_RS_PRODUCT_SUPPLIER_TO_PRODUCT_INFO, Storage = "_RSProductSuppliers", OtherKey = "IdProduct")]
        public EntitySet<ModelRSProductSupplier> RSProductSuppliers
        {
            get
            {
                return this._RSProductSuppliers;
            }
            set
            {
                this._RSProductSuppliers.Assign(value);
            }
        }

        [Association(Name = MyConst.FK_INPUT_PRICE_C_TO_PRODUCT_INFO, Storage = "_SellingPrices", OtherKey = "IdProduct")]
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

        [Association(Name = MyConst.FK_SELLING_PRICE_TO_PRODUCT_INFO, Storage = "_SellingPrices", OtherKey = "IdProduct")]
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