using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name = "Supplier")]
    public class ModelSupplier
    {
        private EntitySet<ModelSupplierInvoiceB> _SupplierInvoiceBs = new EntitySet<ModelSupplierInvoiceB>();
        private EntitySet<ModelSupplierInvoiceC> _SupplierInvoiceCs = new EntitySet<ModelSupplierInvoiceC>();

        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Address")]
        public string Address { get; set; }

        [Column(Name = "Tel")]
        public string Tel { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }

        [Association(Name = MyConst.FK_SUPPLIERINVOICEB_TO_SUPPLIER, Storage = "_SupplierInvoiceBs", OtherKey = "IdSupplier")]
        public EntitySet<ModelSupplierInvoiceB> SupplierInvoiceBs
        {
            get
            {
                return this._SupplierInvoiceBs;
            }
            set
            {
                this._SupplierInvoiceBs = value;
            }
        }

        [Association(Name = MyConst.FK_SUPPLIERINVOICEC_TO_SUPPLIER, Storage = "_SupplierInvoiceCs", OtherKey = "IdSupplier")]
        public EntitySet<ModelSupplierInvoiceC> SupplierInvoiceCs
        {
            get
            {
                return this._SupplierInvoiceCs;
            }
            set
            {
                this._SupplierInvoiceCs = value;
            }
        }
    }
}