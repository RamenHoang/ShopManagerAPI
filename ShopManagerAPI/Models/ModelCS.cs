using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ShopManagerAPI.Const;

namespace ShopManagerAPI.Model
{
    [Table(Name = "CS")]
    class ModelCS
    {
        // Private var here
        private EntityRef<ModelCSe> _CSe = new EntityRef<ModelCSe>();

        // Define column get set
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }
        [Column(Name = "idSePr")]
        public int? IdSePr { get; set; }
        [Column(Name = "idProdInfo")]
        public int? IdProdInfo { get; set; }
        [Column(Name ="sPr")]
        public float? SPr { get; set; }
        [Column(Name ="sRatio")]
        public float? SRatio { get; set; }
        [Column(Name = "q")]
        public float? Q { get; set; }
        [Column(Name ="unit")]
        public string Unit { get; set; }
        [Column(Name ="idCS")]
        public int? IdCS { get; set; }
        [Column(Name ="st")]
        public bool? St { get; set; }
        [Column(Name = "idPrescription")]
        public int IdPrescription { get; set; }
        [Column(Name = "T_Description_01")]
        public string T_Description_01 { get; set; }
        [Column(Name = "T_Description_02")]
        public string T_Description_02 { get; set; }
        [Column(Name ="I_Option_01")]
        public int? I_Option_01 { get; set; }
        [Column(Name = "I_Option_02")]
        public int? I_Option_02 { get; set; }
        [Association(Name = MyConst.FK_CS_TO_CSE, Storage = "_CSe", ThisKey = "IdCS", IsForeignKey = true)]
        public ModelCSe CSe
        {
            get
            {
                return this._CSe.Entity;
            }
            set
            {
                this._CSe.Entity = value;
            }
        }
    }

}
