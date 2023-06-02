using HIMS.Model.Opd.OP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd.OP
{
  public  interface I_CaseDetail
    {
      public  String Insert(CaseDetail CaseDetail);
      // public bool Update(CaseDetail CaseDetail);
    }
}
