using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.Model.Models
{
    [Table("Menus")]
    class Menu
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Url { set; get; }
     
        public int? DisplayOrder { set; get; }
        [Required]
        public int GroupId { set; get; }

        public string Target { set; get; }
        [Required]
        public bool Status { set; get; }
        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { set; get; }
    }
}
