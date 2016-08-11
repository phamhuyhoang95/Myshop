using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.Model.Models
{
    [Table("MenuGroups")]
    class MenuGroup
    {
        [Key]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}
