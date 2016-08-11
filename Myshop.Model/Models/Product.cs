using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Myshop.Model.Abtract;

namespace Myshop.Model.Models
{
    [Table("Products")]
    class Product : Auditable
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryId { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal? Price { set; get; }
        public double Promotion { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public int? ViewCount { set; get; }
        public bool? HotFlag { set; get; }

    }
}
