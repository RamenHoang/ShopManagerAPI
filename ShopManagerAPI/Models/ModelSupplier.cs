﻿using ShopManagerAPI.Const;
using ShopManagerAPI.Models;
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
        private EntitySet<ModelRSProductSupplier> _RSProductSuppliers = new EntitySet<ModelRSProductSupplier>();
        private EntitySet<ModelSupplierInvoice> _SupplierInvoices = new EntitySet<ModelSupplierInvoice>();

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

        [Association(Name = MyConst.FK_RS_PRODUCT_SUPPLIER_TO_SUPPLIER, Storage = "_RSProductSuppliers", OtherKey = "IdSupplier")]
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

        [Association(Name = MyConst.FK_SUPPLIER_INVOICE_TO_SUPPLIER, Storage = "_SupplierInvoice", OtherKey = "IdSupplier")]
        public EntitySet<ModelSupplierInvoice> SupplierInvoices
        {
            get
            {
                return this._SupplierInvoices;
            }
            set
            {
                this._SupplierInvoices.Assign(value);
            }
        }
    }
}

