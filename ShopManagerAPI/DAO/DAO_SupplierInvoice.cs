using ShopManagerAPI.Database;
using ShopManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.DAO
{
    public class DAO_SupplierInvoice
    {
        private SQLServer db;

        public DAO_SupplierInvoice()
        {
            this.db = SQLServer.getDB();
        }

        public ModelSupplierInvoice GetById(int id)
        {
            ModelSupplierInvoice invoice = db.SupplierInvoice.First(p => p.Id == id);
            return invoice;
        }

        public void AddNewSupplierInvoice(ModelSupplierInvoice invoice)
        {
            db.SupplierInvoice.InsertOnSubmit(invoice);
            db.SubmitChanges();
        }
    }
}