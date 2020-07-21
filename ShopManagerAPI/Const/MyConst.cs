using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagerAPI.Const
{
    class MyConst
    {
        public const string DATABASE_SRC = "192.168.1.21\\SQLEXPRESS";
        public const string DATABASE_PORT = "1444";
        public const string DATABASE_NAME = "pharmacy";
        public const string DATABASE_USER = "thienphat";
        public const string DATABASE_PSW = "thienphat";
        public const string FK_CS_TO_CSE = "CS$CSeCS";
        public const string FK_SUPPLIERINVOICEB_TO_SUPPLIER = "SupplierInvoice_B$SupplierSupplierInvoice";
        public const string FK_SUPPLIERINVOICEC_TO_SUPPLIER = "SupplierInvoice_C$SupplierSupplierInvoice";
        public const string FK_RS_PRODUCT_SUPPLIER_TO_SUPPLIER = "FK_RS_Product_Supplier_Supplier";
        public const string FK_RS_PRODUCT_SUPPLIER_TO_PRODUCT_INFO = "FK_RS_Product_Supplier_Supplier";
        public const string FK_INPUT_PRICE_C_TO_PRODUCT_INFO = "InputPrice_C$ProductInfoInputPrice";
        public const string FK_INPUT_PRICE_C_TO_PRODUCT_UNIT = "InputPrice_C$ProductUnitInputPrice";
        public const string FK_INPUT_PRICE_C_TO_SUPPLIER_INVOICE_C = "InputPrice_C$SupplierInvoiceInputPrice_C";
        public const string FK_SELLING_PRICE_TO_PRODUCT_INFO = "FK_SellingPrice_ProductUnit";
        public const string FK_SELLING_PROCE_TO_PRODUCT_UNIT = "FK_SellingPrice_ProductUnit";
    }
}
