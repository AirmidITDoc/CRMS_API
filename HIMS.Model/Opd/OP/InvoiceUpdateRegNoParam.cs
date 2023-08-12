using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Opd.OP
{
   public class InvoiceUpdateRegNoParam
    {
        public UpdateRegno UpdateRegno { get; set; }
    }

    public class UpdateRegno
    {
        public int RegId { get; set; }
        public String ExtRegNo { get; set; }
    }
}
