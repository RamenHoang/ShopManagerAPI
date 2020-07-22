using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "InputPrice")]
    public partial class ModelInputPrice
    {
        private EntityRef<ModelProductInfo> _ProductInfo = new EntityRef<ModelProductInfo>();
        private EntityRef<ModelProductUnit> _ProductUnit = new EntityRef<ModelProductUnit>();
        private EntityRef<ModelSupplierInvoice> _SupplierInvoice = new EntityRef<ModelSupplierInvoice>();


        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "idProduct")]
        public int IdProduct { get; set; }

        [Column(Name = "idUnit_Import")]
        public int IdProductUnit { get; set; }

        [Column(Name = "Quantity", DbType = "float")]
        public float Quantity { get; set; }

        [Column(Name = "UnitPriceNoVAT", DbType = "float")]
        public float? UnitPriceNoVAT { get; set; }

        [Column(Name ="VATPercent", DbType ="float")]
        public float VATPercent { get; set; }

        [Column(Name = "AmountWithVAT", DbType = "float")]
        public float AmountWithVAT { get; set; }

        [Column(Name = "SeriesLot")]
        public string SeriesLot { get; set; }

        [Column(Name = "DateProduction")]
        public DateTime? DateProduction { get; set; }

        [Column(Name = "DateExpiration")]
        public DateTime DateExpiration { get; set; }

        [Column(Name = "idInvoice")]
        public int? IdInvoice { get; set; }

        [Column(Name = "RQ", DbType = "float")]
        public float? RQ { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Column(Name = "AmountRefund", DbType = "float")]
        public float AmountRefund { get; set; }

        [Column(Name = "AmountFinal", DbType = "float")]
        public float AmountFinal { get; set; }

        [Column(Name = "stock")]
        public float Stock { get; set; }

        [Column(Name = "F_Q_Base", DbType = "float")]
        public float? F_Q_Base { get; set; }

        [Column(Name = "F_RQ_Base", DbType = "float")]
        public float? F_RQ_Base { get; set; }

        [Column(Name = "F_Ratio_Base", DbType = "float")]
        public float? F_Ratio_Base { get; set; }

        [Column(Name = "I_Ratio_Unit")]
        public int? I_Ratio_Unit { get; set; }

        [Association(Name = MyConst.FK_INPUT_PRICE_TO_PRODUCT_INFO, IsForeignKey = true, Storage = "_ProductInfo", ThisKey = "IdProduct")]
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

        [Association(Name = MyConst.FK_INPUT_PRICE_TO_PRODUCT_UNIT, IsForeignKey = true, Storage = "_ProductUnit", ThisKey = "IdProductUnit")]
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

        [Association(Name = MyConst.FK_INPUT_PRICE_TO_SUPPLIER_INVOICE, IsForeignKey = true, Storage = "_SupplierInvoice", ThisKey = "IdInvoice")]
        public ModelSupplierInvoice SupplierInvoice
        {
            get
            {
                return this._SupplierInvoice.Entity;
            }
            set
            {
                this._SupplierInvoice.Entity = value;
            }
        }

    }
}