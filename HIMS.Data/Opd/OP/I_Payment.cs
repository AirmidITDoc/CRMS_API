using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
   public interface I_Payment
    {
        //bool Update(PaymentParam PaymentParam);
        bool Save(PaymentParam PaymentParam);
    }
}
