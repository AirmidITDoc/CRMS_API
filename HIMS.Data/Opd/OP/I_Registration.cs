using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
  public  interface I_Registration
    {
        String Insert(RegistrationParam RegistrationParam);
        bool Update(RegistrationParam RegistrationParam);
    }
}
