using ShopManagerAPI.Const;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="PrescriptionContent")]
    public class ModelPrescriptionContent
    {
        private EntityRef<ModelProductInfo> _ProductInfo = new EntityRef<ModelProductInfo>();
        private EntityRef<ModelProductUnit> _ProductUnit = new EntityRef<ModelProductUnit>();
        private EntityRef<ModelPresciption> _Prescription = new EntityRef<ModelPresciption>();

        [Column(Name = "", IsPrimaryKey = true)]
        public int? id;

        [Column(Name = "idPrescription")]
        public int IdPrescription { get; set; }

        [Column(Name = "idProductInfo")]
        public int IdProductInfo { get; set; }

        [Column(Name = "idUnit")]
        public int? IdUnit { get; set; }

        [Column(Name = "quant", DbType = "float")]
        public float? Quantity { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }

        [Association(Name = MyConst.FK_PERSCRIPTION_CONTENT_TO_PERSCRIPTION, IsForeignKey = true, Storage = "_Prescription", ThisKey = "IdPrescription")]
        public ModelPresciption ProductInfo
        {
            get
            {
                return this._Prescription.Entity;
            }
            set
            {
                this._Prescription.Entity = value;
            }
        }

        [Association(Name = MyConst.FK_PERSCRIPTION_CONTENT_TO_PRODUCT_INFO, IsForeignKey = true, Storage = "_ProductInfo", ThisKey = "IdProductInfo")]
        public ModelProductInfo ProductUnit
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

        [Association(Name = MyConst.FK_PERSCRIPTION_CONTENT_TO_PRODUCT_UNIT, IsForeignKey = true, Storage = "_ProductUnit", ThisKey = "IdUnit")]
        public ModelProductUnit SupplierInvoice
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
    }
}