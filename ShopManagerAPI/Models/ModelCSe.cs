﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ShopManagerAPI.Const;

namespace ShopManagerAPI.Model
{
    [Table(Name = "CSe")]
    class ModelCSe
    {
        // Private var here
        private EntitySet<ModelCS> _CS = new EntitySet<ModelCS>();


        // Define Column get set
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name ="sDate")]
        public DateTime SDate { get; set; }


        [Column(Name = "discount", DbType = "float")]
        public float Discount { get; set; }

        [Column(Name = "sum", DbType = "float")]
        public float Sum { get; set; }

        [Column(Name ="cliSum", DbType = "float")]
        public float CliSum { get; set; }

        [Column(Name ="cliReturn", DbType = "float")]
        public float CliReturn { get; set; }

        [Column(Name = "idClient")]
        public int IdClient { get; set; }

        [Column(Name = "withPrescription")]
        public bool WithPrescription { get; set; }

        [Column(Name = "T_Code_01")]
        public string T_Code_01 { get; set; }

        [Column(Name = "T_Code_02")]
        public string T_Code_02 { get; set; }

        [Column(Name = "I_Type")]
        public int? I_Type { get; set; }

        [Column(Name = "I_Status")]
        public int? I_Status { get; set; }
        [Association(Name =MyConst.FK_CS_TO_CSE, Storage ="_CS", OtherKey ="IdCS")]
        public EntitySet<ModelCS> CS
        {
            get
            {
                return this._CS;
            }
            set
            {
                this._CS.Assign(value);
            }
        }

    }
}
