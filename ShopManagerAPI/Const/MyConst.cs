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
        public const string FK_CPI_TO_PRODUCT_UNIT = "FK_CIP_ProductUnit";
        public const string FK_INPUT_PRICE_TO_PRODUCT_INFO = "InputPrice$ProductInfoInputPrice";
        public const string FK_INPUT_PRICE_TO_PRODUCT_UNIT = "InputPrice$ProductUnitInputPrice";
        public const string FK_INPUT_PRICE_TO_SUPPLIER_INVOICE = "InputPrice$SupplierInvoiceInputPrice";
        public const string FK_PERSCRIPTION_CONTENT_TO_PERSCRIPTION = "FK_PresciptionContent_Prescription";
        public const string FK_PERSCRIPTION_CONTENT_TO_PRODUCT_INFO = "FK_PrescriptionContent_ProductInfo";
        public const string FK_PERSCRIPTION_CONTENT_TO_PRODUCT_UNIT = "FK_PrescriptionContent_ProductUnit";
        public const string FK_PRODUCT_UNIT_RATIO_TO_PRODUCT_INFO = "FK_ProductUnitRatio_ProductInfo";
        public const string FK_PRODUCT_UNIT_RATIO_TO_PRODUCT_UNIT = "FK_ProductUnitRatio_ProductUnit";
        public const string FK_SUPPLIER_INVOICE_TO_SUPPLIER = "SupplierInvoice$SupplierSupplierInvoice";
    }
}
