using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "SupplierInvoice_C")]
    public class ModelSupplierInvoiceC
    {
        private EntityRef<ModelSupplier> _Supplier = new EntityRef<ModelSupplier>();
        private EntitySet<ModelInputPriceC> _InputPriceCs = new EntitySet<ModelInputPriceC>();

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "idSupplier")]
        public int IdSupplier { get; set; }

        [Column(Name = "date")]
        public DateTime Date { get; set; }

        [Column(Name = "Num")]
        public string Num { get; set; }

        [Column(Name = "AmountNoVAT", DbType = "float")]
        public float? AmountNoVAT { get; set; }

        [Column(Name = "AmountWithVAT", DbType = "float")]
        public float? AmountWithVAT { get; set; }

        [Column(Name = "Discount", DbType = "float")]
        public float? Discount { get; set; }

        [Column(Name = "DiscountPercent", DbType = "float")]
        public float? DiscountPercent { get; set; }

        [Column(Name = "AmountWithVATFinal", DbType = "float")]
        public float? AmountWithVATFinal { get; set; }

        [Column(Name = "AmountNoVATFinal", DbType = "float")]
        public float? AmountNoVATFinal { get; set; }

        [Column(Name = "hasTransfer")]
        public int? HasTransfer { get; set; }

        [Column(Name = "dateTransfer")]
        public DateTime DateTransfer { get; set; }

        [Column(Name = "inputDate")]
        public DateTime InputDate { get; set; }

        [Association(Name = MyConst.FK_SUPPLIERINVOICEC_TO_SUPPLIER, Storage = "_Supplier", IsForeignKey = true, ThisKey = "IdSupplier")]
        public ModelSupplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                this._Supplier.Entity = value;
            }
        }

        [Association(Name = MyConst.FK_INPUT_PRICE_C_TO_SUPPLIER_INVOICE_C, Storage = "_InputPriceCs", OtherKey = "IdInvoice")]
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
    }
}