using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.Model.Abtract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        string CreateBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        String UpdatedBy { set; get; }
        // seo table
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        // status table
        bool Status { set; get; }
    }
}
