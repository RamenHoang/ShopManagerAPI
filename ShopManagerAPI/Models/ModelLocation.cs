using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace ShopManagerAPI.Models
{
    [Table(Name ="Location")]
    public class ModelLocation
    {
        [Column(Name = "id", IsPrimaryKey =true, IsDbGenerated =true)]
        public int? Id { get; set; }

        [Column(Name = "Location")]
        public string Location { get; set; }
    }
}