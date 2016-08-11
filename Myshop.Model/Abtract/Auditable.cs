using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.Model.Abtract
{
 public abstract class  Auditable :IAuditable
    {
     public DateTime? CreatedDate { get; set; }
     public string CreateBy { get; set; }
     public DateTime? UpdatedDate { get; set; }
     public string UpdatedBy { get; set; }
     public string MetaKeyword { get; set; }
     public string MetaDescription { get; set; }
     public bool Status { get; set; }
    }
}
